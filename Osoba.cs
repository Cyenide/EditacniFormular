using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace EditacniFormular
{
    // pojmenování tabulky v databázi
    [Table("Osoby")]
    public class Osoba
    {
        public int OsobaId { get; set; }
        public string Jmeno { get; set; }
        public string Prijmeni { get; set; }
        public DateTime DatumNarozeni { get; set; }
        public string Telefon { get; set; }
        public string Email { get; set; }
    }
}
