namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addGradesPath : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Exams", "GradesPath", c => c.String());
            DropColumn("dbo.Exams", "IsAnswered");
            DropColumn("dbo.Exams", "FinalGrade");

        }

        public override void Down()
        {
            DropColumn("dbo.Exams", "GradesPath");
        }
    }
}
