namespace MicrosoftIdentity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class JaFoste : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Empresas",
                c => new
                    {
                        idEmpresa = c.Int(nullable: false, identity: true),
                        nome = c.String(),
                    })
                .PrimaryKey(t => t.idEmpresa);
            
            AddColumn("dbo.AspNetUsers", "idEmpresa", c => c.Int());
            CreateIndex("dbo.AspNetUsers", "idEmpresa");
            AddForeignKey("dbo.AspNetUsers", "idEmpresa", "dbo.Empresas", "idEmpresa");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AspNetUsers", "idEmpresa", "dbo.Empresas");
            DropIndex("dbo.AspNetUsers", new[] { "idEmpresa" });
            DropColumn("dbo.AspNetUsers", "idEmpresa");
            DropTable("dbo.Empresas");
        }
    }
}
