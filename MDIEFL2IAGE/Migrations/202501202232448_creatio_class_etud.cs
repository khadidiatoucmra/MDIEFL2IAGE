namespace MDIEFL2IAGE.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class creatio_class_etud : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Classes",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        libelle = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Etudiants",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        prenom = c.String(),
                        nom = c.String(),
                        idClasse = c.Int(nullable: false),
                        classe_id = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Classes", t => t.classe_id)
                .Index(t => t.classe_id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Etudiants", "classe_id", "dbo.Classes");
            DropIndex("dbo.Etudiants", new[] { "classe_id" });
            DropTable("dbo.Etudiants");
            DropTable("dbo.Classes");
        }
    }
}
