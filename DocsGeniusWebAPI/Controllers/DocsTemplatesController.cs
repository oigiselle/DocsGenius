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
    public class DocsTemplatesController : ControllerBase
    {
        private readonly DocsGeniusWebAPIContext _context;

        public DocsTemplatesController(DocsGeniusWebAPIContext context)
        {
            _context = context;
        }

        // GET: api/DocsTemplates
        [HttpGet]
        public async Task<ActionResult<IEnumerable<DocsTemplate>>> GetDocsTemplate()
        {
            return await _context.DocsTemplate.ToListAsync();
        }

        // GET: api/DocsTemplates/5
        [HttpGet("{id}")]
        public async Task<ActionResult<DocsTemplate>> GetDocsTemplate(int id)
        {
            var docsTemplate = await _context.DocsTemplate.FindAsync(id);

            if (docsTemplate == null)
            {
                return NotFound();
            }

            return docsTemplate;
        }

        // PUT: api/DocsTemplates/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDocsTemplate(int id, DocsTemplate docsTemplate)
        {
            if (id != docsTemplate.Id)
            {
                return BadRequest();
            }

            _context.Entry(docsTemplate).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DocsTemplateExists(id))
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

        // POST: api/DocsTemplates
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<DocsTemplate>> PostDocsTemplate(DocsTemplate docsTemplate)
        {
            _context.DocsTemplate.Add(docsTemplate);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetDocsTemplate", new { id = docsTemplate.Id }, docsTemplate);
        }

        // DELETE: api/DocsTemplates/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDocsTemplate(int id)
        {
            var docsTemplate = await _context.DocsTemplate.FindAsync(id);
            if (docsTemplate == null)
            {
                return NotFound();
            }

            _context.DocsTemplate.Remove(docsTemplate);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool DocsTemplateExists(int id)
        {
            return _context.DocsTemplate.Any(e => e.Id == id);
        }
    }
}
