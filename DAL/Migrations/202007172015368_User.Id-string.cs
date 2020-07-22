namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UserIdstring : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Exams", "User_Id", "dbo.Users");
            DropIndex("dbo.Exams", new[] { "User_Id" });
            DropPrimaryKey("dbo.Users");
            AlterColumn("dbo.Exams", "User_Id", c => c.String(maxLength: 128));
            AlterColumn("dbo.Users", "Id", c => c.String(nullable: false, maxLength: 128));
            AddPrimaryKey("dbo.Users", "Id");
            CreateIndex("dbo.Exams", "User_Id");
            AddForeignKey("dbo.Exams", "User_Id", "dbo.Users", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Exams", "User_Id", "dbo.Users");
            DropIndex("dbo.Exams", new[] { "User_Id" });
            DropPrimaryKey("dbo.Users");
            AlterColumn("dbo.Users", "Id", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.Exams", "User_Id", c => c.Int());
            AddPrimaryKey("dbo.Users", "Id");
            CreateIndex("dbo.Exams", "User_Id");
            AddForeignKey("dbo.Exams", "User_Id", "dbo.Users", "Id");
        }
    }
}
