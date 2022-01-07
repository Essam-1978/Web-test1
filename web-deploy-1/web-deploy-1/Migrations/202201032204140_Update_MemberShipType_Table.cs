namespace web_deploy_1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Update_MemberShipType_Table : DbMigration
    {
        public override void Up()
        {
            Sql("Update MemberShipTypes set Name='PayAsYouGo' where DiscountRate=0");
            Sql("Update MemberShipTypes set Name='Monthly' where DiscountRate=10");
            Sql("Update MemberShipTypes set Name='Quarderly' where DiscountRate=15");
            Sql("Update MemberShipTypes set Name='Yearly' where DiscountRate=20");

        }
        
        public override void Down()
        {
        }
    }
}
