namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UserExamsNotMapped : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Exams", "User_Id", "dbo.Users");
            DropIndex("dbo.Exams", new[] { "User_Id" });
            AddColumn("dbo.Exams", "ForMigration", c => c.String());
            DropColumn("dbo.Exams", "User_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Exams", "User_Id", c => c.String(maxLength: 128));
            DropColumn("dbo.Exams", "ForMigration");
            CreateIndex("dbo.Exams", "User_Id");
            AddForeignKey("dbo.Exams", "User_Id", "dbo.Users", "Id");
        }
    }
}
