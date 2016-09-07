namespace NinjaDomain.DataModel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class newPost : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Posts", "TopicId", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Posts", "TopicId");
        }
    }
}
