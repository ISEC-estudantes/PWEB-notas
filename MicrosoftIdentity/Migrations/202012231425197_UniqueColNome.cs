namespace MicrosoftIdentity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UniqueColNome : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Produtoes", "Nome", c => c.String(maxLength: 200));
            CreateIndex("dbo.Produtoes", "Nome", unique: true);
        }
        
        public override void Down()
        {
            DropIndex("dbo.Produtoes", new[] { "Nome" });
            AlterColumn("dbo.Produtoes", "Nome", c => c.String());
        }
    }
}
