namespace NinjaDomain.DataModel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Post : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Posts",
                c => new
                    {
                        PostID = c.Int(nullable: false, identity: true),
                        PostText = c.String(),
                        DateCreated = c.DateTime(nullable: false),
                        DateModified = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.PostID);
            
            CreateTable(
                "dbo.Topics",
                c => new
                    {
                        TopicId = c.Int(nullable: false, identity: true),
                        TopicSubject = c.String(),
                        DateCreated = c.DateTime(nullable: false),
                        DateModified = c.DateTime(nullable: false),
                        Topic_TopicId = c.Int(),
                    })
                .PrimaryKey(t => t.TopicId)
                .ForeignKey("dbo.Topics", t => t.Topic_TopicId)
                .Index(t => t.Topic_TopicId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Topics", "Topic_TopicId", "dbo.Topics");
            DropIndex("dbo.Topics", new[] { "Topic_TopicId" });
            DropTable("dbo.Topics");
            DropTable("dbo.Posts");
        }
    }
}
