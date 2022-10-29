namespace AccDatos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatebrand : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Company", "AddressId", "dbo.Address");
            DropIndex("dbo.Company", new[] { "AddressId" });
            CreateTable(
                "dbo.Brand",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        BrandName = c.String(nullable: false, maxLength: 20),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Address", "UserId", c => c.Long(nullable: false));
            AddColumn("dbo.Product", "BrandId", c => c.Long(nullable: false));
            AlterColumn("dbo.Company", "CUIT", c => c.String(nullable: false, maxLength: 15));
            CreateIndex("dbo.Address", "UserId");
            CreateIndex("dbo.Product", "BrandId");
            AddForeignKey("dbo.Address", "UserId", "dbo.User", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Product", "BrandId", "dbo.Brand", "Id", cascadeDelete: true);
            DropColumn("dbo.Company", "AddressId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Company", "AddressId", c => c.Long(nullable: false));
            DropForeignKey("dbo.Product", "BrandId", "dbo.Brand");
            DropForeignKey("dbo.Address", "UserId", "dbo.User");
            DropIndex("dbo.Product", new[] { "BrandId" });
            DropIndex("dbo.Address", new[] { "UserId" });
            AlterColumn("dbo.Company", "CUIT", c => c.String(nullable: false));
            DropColumn("dbo.Product", "BrandId");
            DropColumn("dbo.Address", "UserId");
            DropTable("dbo.Brand");
            CreateIndex("dbo.Company", "AddressId");
            AddForeignKey("dbo.Company", "AddressId", "dbo.Address", "Id", cascadeDelete: true);
        }
    }
}
