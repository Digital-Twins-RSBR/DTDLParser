using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ParserWebAPI.models;


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
            return await _context.DTDLModels.ToListAsync();
        }

        // GET: api/DTDLModels/5
        [HttpGet("{id}")]
        public async Task<ActionResult<DTDLModel>> GetDTDLModel(string id)
        {
            var dTDLModel = await _context.DTDLModels.FindAsync(id);

            if (dTDLModel == null)
            {
                return NotFound();
            }

            return dTDLModel;
        }

        // PUT: api/DTDLModels/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDTDLModel(string id, DTDLModel dTDLModel)
        {
            if (id != dTDLModel.Id)
            {
                return BadRequest();
            }

            _context.Entry(dTDLModel).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DTDLModelExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/DTDLModels
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<DTDLModel>> PostDTDLModel(DTDLModel dTDLModel)
        {
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
