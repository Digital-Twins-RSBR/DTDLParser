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
using Microsoft.CodeAnalysis.CSharp;


// Implementar a chamada ao parser a partir do envio de uma descrição de modelo(usando string)

namespace ParserWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DTDLModelsController : ControllerBase
    {
        private readonly DTDLModelContext _context;

        private readonly DTDLSpecificationContext _contextSpecification;

        private readonly ModelResolver modelResolver;

        public DTDLModelsController(DTDLModelContext context, DTDLSpecificationContext contextSpecification)
        {
            _context = context;
            _contextSpecification = contextSpecification;
            modelResolver = new ModelResolver(_contextSpecification);
            
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

        // GET: api/DTDLModels/specifications
        [HttpGet("specifications")]
        public async Task<ActionResult<IEnumerable<DTDLSpecification>>> GetAllSpecifications()
        {
            var specifications = await _contextSpecification.DTDLSpecifications.ToListAsync();
            return Ok(specifications);
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
        public async Task<ActionResult<DTDLModel>> ParseDTDLModel([FromBody] DTDLSpecification model)
        {
            
                var dTDLModel = new DTDLModel();
                dTDLModel.Id = model.id;
                dTDLModel.modelElements = new List<ModelElement>();
                dTDLModel.modelRelationships = new List<ModelRelationship>();
            try{
                var result = await modelResolver.LoadModelAsyncFromString(model.id, model.specification.ToString());

                //Filling properties

                var indexLastTwoDots = model.id.LastIndexOf(':');
                var indexFirstSemicolon = model.id.IndexOf(';', indexLastTwoDots);
                var modelName = indexLastTwoDots != -1 && indexFirstSemicolon != -1 && indexFirstSemicolon > indexLastTwoDots
                    ? model.id.Substring(indexLastTwoDots + 1, indexFirstSemicolon - indexLastTwoDots - 1)
                    : "";


                dTDLModel.Name = modelName;

                foreach (var prop in result.Properties)
                {
                    var modelElement = new ModelElement();
                    modelElement.name = prop.Value.Name;
                    modelElement.type = "Property";
                    modelElement.schema = prop.Value.Schema.EntityKind.ToString();
                    modelElement.supplementTypes = new List<string>();
                    foreach (var type in prop.Value.SupplementalTypes)
                    {
                        modelElement.supplementTypes.Add(type.ToString());
                    }
                    dTDLModel.modelElements.Add(modelElement);
                }

                //Filling Telemetries

                foreach (var telemetry in result.Telemetries)
                {
                    var modelElement = new ModelElement();
                    modelElement.name = telemetry.Value.Name;
                    modelElement.type = "Telemetry";
                    modelElement.schema = telemetry.Value.Schema.EntityKind.ToString();
                    modelElement.supplementTypes = new List<string>();
                    foreach (var type in telemetry.Value.SupplementalTypes)
                    {
                        modelElement.supplementTypes.Add(type.ToString());
                    }
                    dTDLModel.modelElements.Add(modelElement);
                }

                //Filling Relationships

                foreach (var relationship in result.Relationships)
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

               
            }catch(ParsingException parseException)
            {
                return StatusCode(501,new {error=$"Parsing error: {parseException.Message}"});
            }catch(Exception e)
            {
                return StatusCode(502,new {error=$"Internal error: {e.Message}"});
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
