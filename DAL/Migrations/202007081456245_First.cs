namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class First : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Classrooms",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Exams",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        ClassroomId = c.Int(nullable: false),
                        IsTimed = c.Boolean(nullable: false),
                        QuestionsPath = c.String(),
                        FinalGrade = c.Double(nullable: false),
                        User_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Classrooms", t => t.ClassroomId, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.User_Id)
                .Index(t => t.ClassroomId)
                .Index(t => t.User_Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Role = c.Int(nullable: false),
                        ClassroomId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Classrooms", t => t.ClassroomId, cascadeDelete: true)
                .Index(t => t.ClassroomId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Users", "ClassroomId", "dbo.Classrooms");
            DropForeignKey("dbo.Exams", "User_Id", "dbo.Users");
            DropForeignKey("dbo.Exams", "ClassroomId", "dbo.Classrooms");
            DropIndex("dbo.Users", new[] { "ClassroomId" });
            DropIndex("dbo.Exams", new[] { "User_Id" });
            DropIndex("dbo.Exams", new[] { "ClassroomId" });
            DropTable("dbo.Users");
            DropTable("dbo.Exams");
            DropTable("dbo.Classrooms");
        }
    }
}
