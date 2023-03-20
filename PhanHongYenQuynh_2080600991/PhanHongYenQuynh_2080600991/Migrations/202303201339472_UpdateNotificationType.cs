namespace PhanHongYenQuynh_2080600991.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateNotificationType : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Notifications", "Course_Id1", c => c.Int());
            AlterColumn("dbo.Notifications", "Type", c => c.Int(nullable: false));
            CreateIndex("dbo.Notifications", "Course_Id1");
            AddForeignKey("dbo.Notifications", "Course_Id1", "dbo.Courses", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Notifications", "Course_Id1", "dbo.Courses");
            DropIndex("dbo.Notifications", new[] { "Course_Id1" });
            AlterColumn("dbo.Notifications", "Type", c => c.String());
            DropColumn("dbo.Notifications", "Course_Id1");
        }
    }
}
