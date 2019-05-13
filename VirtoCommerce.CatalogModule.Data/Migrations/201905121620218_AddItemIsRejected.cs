namespace VirtoCommerce.CatalogModule.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddItemIsRejected : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Item", "IsRejected", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Item", "IsRejected");
        }
    }
}
