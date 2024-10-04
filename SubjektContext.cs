using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EditacniFormular
{
    // třída zodpovědná za navázání spojení s databází a její modelování
    public class SubjektContext : DbContext
    {
        // reprezentuje kolekci všech entit v tomto kontextu
        public DbSet<Osoba> Subjekty { get; set; }

        // pojmenování databáze v kostruktoru kontextu
        public SubjektContext() : base("SubjektyDB")
        {

        }
    }
}
