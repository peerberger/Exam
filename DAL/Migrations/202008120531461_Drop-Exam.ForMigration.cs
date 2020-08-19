namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DropExamForMigration : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Exams", "ForMigration");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Exams", "ForMigration", c => c.String());
        }
    }
}
