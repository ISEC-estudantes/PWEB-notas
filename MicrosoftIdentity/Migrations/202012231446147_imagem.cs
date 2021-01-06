namespace MicrosoftIdentity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class imagem : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Produtoes", "imagem", c => c.String(maxLength: 500));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Produtoes", "imagem");
        }
    }
}
