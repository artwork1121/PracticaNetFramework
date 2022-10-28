namespace AccDatos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class update : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Stock", "ProductId", c => c.Long(nullable: false));
            AlterColumn("dbo.Product", "ProductName", c => c.String(nullable: false, maxLength: 60));
            AlterColumn("dbo.Product", "ProductDescription", c => c.String(nullable: false, maxLength: 100));
            CreateIndex("dbo.Stock", "ProductId");
            AddForeignKey("dbo.Stock", "ProductId", "dbo.Product", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Stock", "ProductId", "dbo.Product");
            DropIndex("dbo.Stock", new[] { "ProductId" });
            AlterColumn("dbo.Product", "ProductDescription", c => c.String(nullable: false, maxLength: 40));
            AlterColumn("dbo.Product", "ProductName", c => c.String(nullable: false, maxLength: 20));
            DropColumn("dbo.Stock", "ProductId");
        }
    }
}
