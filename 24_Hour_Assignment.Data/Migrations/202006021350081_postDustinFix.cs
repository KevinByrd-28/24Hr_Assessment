namespace _24_Hour_Assignment.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class postDustinFix : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Post", "Text", c => c.String(nullable: false, maxLength: 1000));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Post", "Text", c => c.String(nullable: false, maxLength: 100));
        }
    }
}
