using junBackend.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace junBackend.Controller
{
    public class AktivnostController : ControllerBase
    {
        private readonly DbC db;

        public AktivnostController(DbC dc)
        {
            this.db = dc;
        }

        [HttpGet("getAktivnosti")]
        public async Task<IActionResult> getAktivnosti()
        {
            var aktivnosti = await db.aktivnost.ToListAsync();

            return Ok(aktivnosti);
        }

        [HttpGet("getAktivnosti/{id}")]
        public async Task<IActionResult> getAktivnosti(int id)
        {
            var aktivnost = await db.aktivnost.FirstOrDefaultAsync(a => a.id == id);

            return Ok(aktivnost);
        }

        [HttpPost("postAktivnost")]
        public async Task<IActionResult>postAktivnost([FromBody] Aktivnost ak)
        {
            await db.aktivnost.AddAsync(ak);
            await db.SaveChangesAsync();

            return Ok(ak);
        }

        [HttpPut("UpdateAktivnost/{id}/{opis}")]
        public async Task<IActionResult> UpdateAktivnost(int id, string opis)
        {
            var aktivnost = await db.aktivnost.FindAsync(id);

            if(aktivnost == null)
            {
                return NotFound();
            }

            aktivnost.opis = opis;

            await db.SaveChangesAsync();

            return NoContent();
        }

    }
}
