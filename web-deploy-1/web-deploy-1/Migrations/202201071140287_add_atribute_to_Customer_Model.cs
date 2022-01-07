namespace web_deploy_1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class add_atribute_to_Customer_Model : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Customers", "Name", c => c.String(nullable: false, maxLength: 255));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Customers", "Name", c => c.String());
        }
    }
}
