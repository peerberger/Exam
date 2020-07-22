namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ModExamFinalGradeNullable : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Exams", "FinalGrade", c => c.Double());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Exams", "FinalGrade", c => c.Double(nullable: false));
        }
    }
}
