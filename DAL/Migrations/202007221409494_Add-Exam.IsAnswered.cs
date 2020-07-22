namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddExamIsAnswered : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Exams", "IsAnswered", c => c.Boolean(nullable: true));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Exams", "IsAnswered");
        }
    }
}
