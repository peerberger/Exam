namespace DAL.Migrations
{
	using System;
	using System.Data.Entity.Migrations;

	public partial class ModQImagesCompositeKeys : DbMigration
	{
		public override void Up()
		{
			DropPrimaryKey("dbo.QImages");
			AlterColumn("dbo.QImages", "Id", c => c.Int(nullable: false, identity: false));
			AddPrimaryKey("dbo.QImages", new[] { "Id", "ExamId" });
		}

		public override void Down()
		{
			DropPrimaryKey("dbo.QImages");
			AlterColumn("dbo.QImages", "Id", c => c.Int(nullable: false, identity: false));
			AddPrimaryKey("dbo.QImages", "Id");
		}
	}
}
