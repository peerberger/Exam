namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddClassrooms_Users : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Users", "ClassroomId", "dbo.Classrooms");
            DropIndex("dbo.Users", new[] { "ClassroomId" });
            CreateTable(
                "dbo.Classrooms_Users",
                c => new
                    {
                        UserId = c.String(nullable: false, maxLength: 128),
                        ClassroomId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.UserId, t.ClassroomId })
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .ForeignKey("dbo.Classrooms", t => t.ClassroomId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.ClassroomId);
            
            DropColumn("dbo.Users", "ClassroomId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Users", "ClassroomId", c => c.Int(nullable: false));
            DropForeignKey("dbo.Classrooms_Users", "ClassroomId", "dbo.Classrooms");
            DropForeignKey("dbo.Classrooms_Users", "UserId", "dbo.Users");
            DropIndex("dbo.Classrooms_Users", new[] { "ClassroomId" });
            DropIndex("dbo.Classrooms_Users", new[] { "UserId" });
            DropTable("dbo.Classrooms_Users");
            CreateIndex("dbo.Users", "ClassroomId");
            AddForeignKey("dbo.Users", "ClassroomId", "dbo.Classrooms", "Id", cascadeDelete: true);
        }
    }
}
