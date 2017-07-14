namespace MyFirstMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateMakeDatetimeNullableInMovies : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Movies", "ReleaseDate", c => c.DateTime(nullable: true));
            AlterColumn("dbo.Movies", "DateAdded", c => c.DateTime(nullable: true));
            AlterColumn("dbo.Movies", "NumberOfCopies", c => c.Int(nullable: true));
        }
        
        public override void Down()
        {
        }
    }
}
