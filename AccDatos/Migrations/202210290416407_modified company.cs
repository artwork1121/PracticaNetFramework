namespace AccDatos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class modifiedcompany : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Company", "CompanyName", c => c.String(nullable: false, maxLength: 20));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Company", "CompanyName");
        }
    }
}
