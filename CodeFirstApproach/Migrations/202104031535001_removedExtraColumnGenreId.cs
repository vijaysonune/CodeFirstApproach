namespace CodeFirstApproach.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class removedExtraColumnGenreId : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Videos", "GenreId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Videos", "GenreId", c => c.Int(nullable: false));
        }
    }
}
