using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ParserWebAPI.models;
using ParserWebAPI.resolver;
using DTDLParser;


// Implementar a chamada ao parser a partir do envio de uma descrição de modelo(usando string)

namespace ParserWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DTDLModelsController : ControllerBase
    {
        private readonly DTDLModelContext _context;

        public DTDLModelsController(DTDLModelContext context)
        {
            _context = context;
        }

        // GET: api/DTDLModels
        [HttpGet]
        public async Task<ActionResult<IEnumerable<DTDLModel>>> GetDTDLModels()
        {
            return await _context.DTDLModels
                .Include(m => m.modelElements)
                .Include(m => m.modelRelationships)
                .ToListAsync();
        }

        // GET: api/DTDLModels/5
        [HttpGet("{id}")]
        public async Task<ActionResult<DTDLModel>> GetDTDLModel(string id)
        {
            var dTDLModel = await _context.DTDLModels
                .Include(m => m.modelElements)
                .Include(m => m.modelRelationships)
                .FirstOrDefaultAsync(m => m.Id == id);

            if (dTDLModel == null)
            {
                return NotFound();
            }

            return dTDLModel;
        }

        

       

        [HttpPost("parse")]
        public async Task<ActionResult<DTDLModel>> ParseDTDLModel([FromBody]  DTDLSpecification model)
        {
            var dTDLModel = new DTDLModel();
            dTDLModel.Id = model.id;
            dTDLModel.modelElements = new List<ModelElement>();
            dTDLModel.modelRelationships = new List<ModelRelationship>();

            var result = await ModelResolver.LoadModelAsyncFromString(model.id, model.specification.ToString());

            //Filling properties

            foreach (var prop in result.Properties)
            {
                var supType = prop.Value.SupplementalTypes.Count <= 0 ? "N" : prop.Value.SupplementalTypes.Single().ToString();
                var modelElement = new ModelElement();
                modelElement.name = prop.Value.Name;
                modelElement.type = "Property";
                modelElement.schema = prop.Value.Schema.EntityKind.ToString();
                modelElement.supplementType = supType;
                dTDLModel.modelElements.Add(modelElement);
            }

            //Filling Telemetries

            foreach(var telemetry in result.Telemetries)
            {
                var modelElement = new ModelElement();
                modelElement.name = telemetry.Value.Name;
                modelElement.type = "Telemetry";
                modelElement.schema = telemetry.Value.Schema.EntityKind.ToString();
                var supType = telemetry.Value.SupplementalTypes.Count <= 0 ? "N" : telemetry.Value.SupplementalTypes.Single().ToString();
                modelElement.supplementType = supType;
                dTDLModel.modelElements.Add(modelElement);
            }

            //Filling Relationships

            foreach(var relationship in result.Relationships)
            {
                var modelRelationship = new ModelRelationship();
                modelRelationship.name = relationship.Value.Name;
                modelRelationship.target = relationship.Value.Target.ToString();
                dTDLModel.modelRelationships.Add(modelRelationship);
            }

            _context.DTDLModels.Add(dTDLModel);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (DTDLModelExists(dTDLModel.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetDTDLModel", new { id = dTDLModel.Id }, dTDLModel);
        }

        // DELETE: api/DTDLModels/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDTDLModel(string id)
        {
            var dTDLModel = await _context.DTDLModels.FindAsync(id);
            if (dTDLModel == null)
            {
                return NotFound();
            }

            _context.DTDLModels.Remove(dTDLModel);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool DTDLModelExists(string id)
        {
            return _context.DTDLModels.Any(e => e.Id == id);
        }
    }
}
