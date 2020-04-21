using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using FirstAPI.Data;
using FirstAPI.Modals;

namespace FirstAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SessionAPIsController : ControllerBase
    {
        private readonly SessionAPIContext _context;

        public SessionAPIsController(SessionAPIContext context)
        {
            _context = context;
        }

        // GET: api/SessionAPIs
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SessionAPI>>> GetSessionAPI()
        {
            return await _context.SessionAPI.ToListAsync();
        }

        // GET: api/SessionAPIs/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SessionAPI>> GetSessionAPI(int id)
        {
            var sessionAPI = await _context.SessionAPI.FindAsync(id);

            if (sessionAPI == null)
            {
                return NotFound();
            }

            return sessionAPI;
        }

        // PUT: api/SessionAPIs/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSessionAPI(int id, SessionAPI sessionAPI)
        {
            if (id != sessionAPI.ID)
            {
                return BadRequest();
            }

            _context.Entry(sessionAPI).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SessionAPIExists(id))
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

        // POST: api/SessionAPIs
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<SessionAPI>> PostSessionAPI(SessionAPI sessionAPI)
        {
            _context.SessionAPI.Add(sessionAPI);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetSessionAPI", new { id = sessionAPI.ID }, sessionAPI);
        }

        // DELETE: api/SessionAPIs/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<SessionAPI>> DeleteSessionAPI(int id)
        {
            var sessionAPI = await _context.SessionAPI.FindAsync(id);
            if (sessionAPI == null)
            {
                return NotFound();
            }

            _context.SessionAPI.Remove(sessionAPI);
            await _context.SaveChangesAsync();

            return sessionAPI;
        }

        private bool SessionAPIExists(int id)
        {
            return _context.SessionAPI.Any(e => e.ID == id);
        }
    }
}
