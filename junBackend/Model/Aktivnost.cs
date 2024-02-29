namespace junBackend.Model
{
    public class Aktivnost
    {
        public int id { get; set; }
        public string tip { get; set; }
        public string opis { get; set; }
        public int prioritet { get; set; }
        public string datum { get; set; }
        public string vreme { get; set; }
        public int idKorisnika { get; set; }
    }
}
