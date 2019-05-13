namespace VirtoCommerce.CatalogModule.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddItemApprovalMembers : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Item", "IsPendingApproval", c => c.Boolean(nullable: false));
            AddColumn("dbo.Item", "IsApproved", c => c.Boolean(nullable: false));
            AddColumn("dbo.Item", "RejectionReason", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Item", "RejectionReason");
            DropColumn("dbo.Item", "IsApproved");
            DropColumn("dbo.Item", "IsPendingApproval");
        }
    }
}
