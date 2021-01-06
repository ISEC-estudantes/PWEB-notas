namespace MicrosoftIdentity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class teste : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Produtoes", new[] { "Nome" });
            AlterColumn("dbo.Produtoes", "Nome", c => c.String());
            AlterColumn("dbo.Produtoes", "imagem", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Produtoes", "imagem", c => c.String(maxLength: 500));
            AlterColumn("dbo.Produtoes", "Nome", c => c.String(maxLength: 200));
            CreateIndex("dbo.Produtoes", "Nome", unique: true);
        }
    }
}
