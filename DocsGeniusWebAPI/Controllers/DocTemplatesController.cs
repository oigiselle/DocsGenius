using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DocsGenius.Models;
using DocsGeniusWebAPI.Data;

namespace DocsGeniusWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DocTemplatesController : ControllerBase
    {
        private readonly ApiDbContext _context;

        public DocTemplatesController(ApiDbContext context)
        {
            _context = context;
        }

        // GET: api/DocTemplates
        [HttpGet]
        public async Task<ActionResult<IEnumerable<DocTemplate>>> GetDocTemplates()
        {
            return await _context.DocTemplates.ToListAsync();
        }

        // GET: api/DocTemplates/5
        [HttpGet("{id}")]
        public async Task<ActionResult<DocTemplate>> GetDocTemplate(int id)
        {
            var docTemplate = await _context.DocTemplates.FindAsync(id);

            if (docTemplate == null)
            {
                return NotFound();
            }

            return docTemplate;
        }

        // PUT: api/DocTemplates/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDocTemplate(int id, DocTemplate docTemplate)
        {
            if (id != docTemplate.Id)
            {
                return BadRequest();
            }

            _context.Entry(docTemplate).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DocTemplateExists(id))
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

        // POST: api/DocTemplates
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<DocTemplate>> PostDocTemplate(DocTemplate docTemplate)
        {
            _context.DocTemplates.Add(docTemplate);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetDocTemplate", new { id = docTemplate.Id }, docTemplate);
        }

        // DELETE: api/DocTemplates/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDocTemplate(int id)
        {
            var docTemplate = await _context.DocTemplates.FindAsync(id);
            if (docTemplate == null)
            {
                return NotFound();
            }

            _context.DocTemplates.Remove(docTemplate);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool DocTemplateExists(int id)
        {
            return _context.DocTemplates.Any(e => e.Id == id);
        }
    }
}
