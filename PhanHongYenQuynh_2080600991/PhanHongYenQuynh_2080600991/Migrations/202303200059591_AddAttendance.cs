namespace PhanHongYenQuynh_2080600991.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddAttendance : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Attendances",
                c => new
                    {
                        CourseId = c.Int(nullable: false),
                        AttendanceId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.CourseId, t.AttendanceId })
                .ForeignKey("dbo.Courses", t => t.CourseId)
                .Index(t => t.CourseId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Attendances", "CourseId", "dbo.Courses");
            DropIndex("dbo.Attendances", new[] { "CourseId" });
            DropTable("dbo.Attendances");
        }
    }
}
