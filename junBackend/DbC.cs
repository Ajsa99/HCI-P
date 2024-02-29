using junBackend.Model;
using Microsoft.EntityFrameworkCore;

namespace junBackend
{
    public class DbC : DbContext
    {
        public DbC(DbContextOptions<DbC> options) : base(options) { }

        //ovde dodajemo klasu za bazu
        public DbSet<Aktivnost> aktivnost { get; set; }
        public DbSet<Korisnik> korisnik { get; set; }

    }
}
