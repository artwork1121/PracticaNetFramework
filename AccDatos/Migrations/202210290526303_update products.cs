namespace AccDatos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateproducts : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Product", "Image", c => c.Binary());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Product", "Image");
        }
    }
}
