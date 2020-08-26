namespace DAL.Migrations
{
	using System;
	using System.Data.Entity.Migrations;

	public partial class AddQImagesTable : DbMigration
	{
		public override void Up()
		{
			CreateTable(
				"dbo.QImages",
				c => new
				{
					Id = c.Int(nullable: false, identity: false),
					ExamId = c.Int(nullable: false),
					QuestionImage = c.Binary(),
				})
				.PrimaryKey(t => t.Id)
				.ForeignKey("dbo.Exams", t => t.ExamId, cascadeDelete: true);

		}

		public override void Down()
		{
			DropForeignKey("dbo.QImages", "ExamId", "dbo.Exams");
			DropTable("dbo.QImages");
		}
	}
}
