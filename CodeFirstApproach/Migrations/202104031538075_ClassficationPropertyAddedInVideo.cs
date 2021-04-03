namespace CodeFirstApproach.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ClassficationPropertyAddedInVideo : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Videos", "Classfication", c => c.Byte(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Videos", "Classfication");
        }
    }
}
