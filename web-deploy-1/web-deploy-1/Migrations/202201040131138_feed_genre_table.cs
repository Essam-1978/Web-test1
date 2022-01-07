namespace web_deploy_1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class feed_genre_table : DbMigration
    {
        public override void Up()
        {
            Sql("insert into Genres (Id,Name) values(1,'Comedy') ");
            Sql("insert into Genres (Id,Name) values(2,'Romantic') ");
            Sql("insert into Genres (Id,Name) values(3,'Action') ");
        }
        
        public override void Down()
        {
        }
    }
}
