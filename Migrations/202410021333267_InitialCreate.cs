namespace EditacniFormular.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    // první vytvoření databáze
    public partial class InitialCreate : DbMigration
    {
        // metoda se spustí při upgradu (aplikování migrace)
        public override void Up()
        {
            // vytvoření tabulky se sloupci na základě třídy Osoba.cs
            CreateTable(
                "dbo.Osoby",
                c => new
                    {
                        OsobaId = c.Int(nullable: false, identity: true),
                        Jmeno = c.String(nullable: false),
                        Prijmeni = c.String(nullable: false),
                        DatumNarozeni = c.DateTime(nullable: false),
                        Telefon = c.String(),
                        Email = c.String(),
                    })
                .PrimaryKey(t => t.OsobaId); // nastavení vlastnosti Osoba.OsobaId jako primárního klíče v tabulce
            
        }
        
        // metoda se spustí při downgradu (návrat na předchozí migraci)
        public override void Down()
        {
            DropTable("dbo.Osoby");
        }
    }
}
