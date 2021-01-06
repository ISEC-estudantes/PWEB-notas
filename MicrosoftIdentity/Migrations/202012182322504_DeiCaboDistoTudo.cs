namespace MicrosoftIdentity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DeiCaboDistoTudo : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Compras", "IDProduto", "dbo.Produtoes");
            DropIndex("dbo.Compras", new[] { "IDProduto" });
            AddColumn("dbo.Compras", "DataDaCompra", c => c.DateTime(nullable: false));
            AddColumn("dbo.CompraProdutoes", "IDCompra", c => c.Int(nullable: false));
            AddColumn("dbo.CompraProdutoes", "IDProduto", c => c.Int(nullable: false));
            AddColumn("dbo.CompraProdutoes", "Quantidade", c => c.Int(nullable: false));
            CreateIndex("dbo.CompraProdutoes", "IDCompra");
            CreateIndex("dbo.CompraProdutoes", "IDProduto");
            AddForeignKey("dbo.CompraProdutoes", "IDCompra", "dbo.Compras", "IDCompra", cascadeDelete: true);
            AddForeignKey("dbo.CompraProdutoes", "IDProduto", "dbo.Produtoes", "IDProduto", cascadeDelete: true);
            DropColumn("dbo.Compras", "IDProduto");
            DropColumn("dbo.Compras", "userId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Compras", "userId", c => c.String());
            AddColumn("dbo.Compras", "IDProduto", c => c.Int(nullable: false));
            DropForeignKey("dbo.CompraProdutoes", "IDProduto", "dbo.Produtoes");
            DropForeignKey("dbo.CompraProdutoes", "IDCompra", "dbo.Compras");
            DropIndex("dbo.CompraProdutoes", new[] { "IDProduto" });
            DropIndex("dbo.CompraProdutoes", new[] { "IDCompra" });
            DropColumn("dbo.CompraProdutoes", "Quantidade");
            DropColumn("dbo.CompraProdutoes", "IDProduto");
            DropColumn("dbo.CompraProdutoes", "IDCompra");
            DropColumn("dbo.Compras", "DataDaCompra");
            CreateIndex("dbo.Compras", "IDProduto");
            AddForeignKey("dbo.Compras", "IDProduto", "dbo.Produtoes", "IDProduto", cascadeDelete: true);
        }
    }
}
