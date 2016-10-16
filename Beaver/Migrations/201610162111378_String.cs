namespace Beaver.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class String : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Videos", "Name", c => c.String());
            AddColumn("dbo.Videos", "Issue", c => c.String());
            DropColumn("dbo.Videos", "Title");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Videos", "Title", c => c.String());
            DropColumn("dbo.Videos", "Issue");
            DropColumn("dbo.Videos", "Name");
        }
    }
}
