namespace Models.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NewChanges : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.InventoryHoldings", "Product_Sale_Price", c => c.String(maxLength: 150));
            AddColumn("dbo.ProductReceiveds", "Product_Sale_Price", c => c.String(maxLength: 150));
        }
        
        public override void Down()
        {
            DropColumn("dbo.ProductReceiveds", "Product_Sale_Price");
            DropColumn("dbo.InventoryHoldings", "Product_Sale_Price");
        }
    }
}
