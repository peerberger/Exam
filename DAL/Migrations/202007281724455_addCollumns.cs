namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addCollumns : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Exams", "FinalGrade", c => c.Double(nullable:true));
            AddColumn("dbo.Exams", "IsAnswered", c => c.Boolean());
        }

        public override void Down()
        {
            DropColumn("dbo.Exams", "FinalGrade");
            DropColumn("dbo.Exams", "IsAnswered");
        }
    }
}
