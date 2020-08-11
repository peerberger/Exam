namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DropUserIDFromExam : DbMigration
    {
        
        public override void Up()
        {
            AddColumn("dbo.Exams", "ForMigration", c => c.String());
            DropForeignKey("dbo.Exams", "User_Id", "dbo.Users");
            DropIndex("dbo.Exams",new[] { "User_Id" });
            DropColumn("dbo.Exams", "User_Id");
        }
        
        public override void Down()
        {
            DropColumn("dbo.Exams", "ForMigration");
            AddColumn("dbo.Exams", "User_Id", c => c.String(maxLength: 128));
            AddForeignKey("dbo.Exams", "User_Id", "dbo.Users", "Id");
            CreateIndex("dbo.Exams", "User_Id");
        }
    }
}
