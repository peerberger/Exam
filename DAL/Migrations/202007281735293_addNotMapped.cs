namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addNotMapped : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Exams", "FinalGrade");
            DropColumn("dbo.Exams", "IsAnswered");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Exams", "IsAnswered", c => c.Boolean(nullable: false));
            AddColumn("dbo.Exams", "FinalGrade", c => c.Double());
        }
    }
}
