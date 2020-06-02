namespace _24_Hour_Assignment.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Migration2 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Post", "PostID", "dbo.User");
            DropForeignKey("dbo.Comment", "CommentPost_PostID", "dbo.Post");
           // DropIndex("dbo.Post", new[] { "PostID" });
            DropPrimaryKey("dbo.Post");
            AddColumn("dbo.Post", "UserNum", c => c.Int(nullable: false));
            AlterColumn("dbo.Post", "PostID", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.Post", "PostID");
           // CreateIndex("dbo.Post", "PostID");
            AddForeignKey("dbo.Post", "UserNum", "dbo.User", "UserNumber", cascadeDelete: true);
            AddForeignKey("dbo.Comment", "CommentPost_PostID", "dbo.Post", "PostID", cascadeDelete: false);
            DropColumn("dbo.User", "PostID");
            DropColumn("dbo.Post", "UserNumber");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Post", "UserNumber", c => c.Int(nullable: false));
            AddColumn("dbo.User", "PostID", c => c.Int(nullable: false));
            DropForeignKey("dbo.Comment", "CommentPost_PostID", "dbo.Post");
            DropForeignKey("dbo.Post", "UserNum", "dbo.User");
            DropIndex("dbo.Post", new[] { "PostID" });
            DropPrimaryKey("dbo.Post");
            AlterColumn("dbo.Post", "PostID", c => c.Int(nullable: false));
            DropColumn("dbo.Post", "UserNum");
            AddPrimaryKey("dbo.Post", "PostID");
            //CreateIndex("dbo.Post", "PostID");
            AddForeignKey("dbo.Comment", "CommentPost_PostID", "dbo.Post", "PostID", cascadeDelete: true);
            AddForeignKey("dbo.Post", "PostID", "dbo.User", "UserNumber");
        }
    }
}
