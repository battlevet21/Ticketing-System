namespace Beaver.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddVideosTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Videos",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Issue = c.String(),
                        Description = c.String(),
                        
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Videos");
        }
    }
}
