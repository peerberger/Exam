namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddExamTime : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Exams", "Time", c => c.Int());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Exams", "Time");
        }
    }
}
