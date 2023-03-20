namespace PhanHongYenQuynh_2080600991.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateAttendance : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Attendances", "Attendee_Id", c => c.String(maxLength: 128));
            CreateIndex("dbo.Attendances", "Attendee_Id");
            AddForeignKey("dbo.Attendances", "Attendee_Id", "dbo.AspNetUsers", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Attendances", "Attendee_Id", "dbo.AspNetUsers");
            DropIndex("dbo.Attendances", new[] { "Attendee_Id" });
            DropColumn("dbo.Attendances", "Attendee_Id");
        }
    }
}
