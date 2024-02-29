using junBackend.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace junBackend.Controller
{
    public class KorisnikController : ControllerBase
    {
        private readonly DbC db;

        public KorisnikController(DbC dc)
        {
            this.db = dc;
        }

        [HttpGet("getKorisnici")]
        public async Task<IActionResult>getKorisnici()
        {
            var korisnici = await db.korisnik.ToListAsync();

            if(korisnici == null)
            {
                return NotFound();
            }

            return Ok(korisnici);
        }

        [HttpPost("addKorisnik")]
        public async Task<IActionResult>addKorisnik([FromBody] Korisnik korisnik)
        {
            var kor = await db.korisnik.FirstOrDefaultAsync(k => k.ime == korisnik.ime);

            if(kor != null)
            {
                return Ok(new { msg = "Korisnik vec postoji" });
            }

            await db.korisnik.AddAsync(korisnik);
            await db.SaveChangesAsync();

            return Ok(korisnik);
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] Korisnik k)
        {
            var korisnik = await db.korisnik.FirstOrDefaultAsync(ko =>ko.ime == k.ime);

            if(korisnik == null)
            {
                return Ok(new { msg = "korisnik nije registrovan" });
            }

            if(korisnik.lozinka != k.lozinka)
            {
                return Ok(new { msg = "lozinka nije ispravna" });
            }

            return Ok(korisnik);
        }
           
    }
}
