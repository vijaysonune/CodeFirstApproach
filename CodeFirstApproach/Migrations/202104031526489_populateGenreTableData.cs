namespace CodeFirstApproach.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class populateGenreTableData : DbMigration
    {
        public override void Up()
        {
            Sql("Insert into Genres (Id,Name) values (1,'Comedy')");
            Sql("Insert into Genres (Id,Name) values (2,'Action')");
            Sql("Insert into Genres (Id,Name) values (3,'Horror')");
            Sql("Insert into Genres (Id,Name) values (4,'Thriller')");
        }
        
        public override void Down()
        {
            Sql("Delete from Genres");
        }
    }
}
