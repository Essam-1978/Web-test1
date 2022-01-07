namespace web_deploy_1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class add_atribute4_to_Customer_Model : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "Birthdate", c => c.DateTime());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customers", "Birthdate");
        }
    }
}
