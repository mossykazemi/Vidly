namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMovie : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Genres (Id,Name) Values(1,'Action')");
            Sql("INSERT INTO Genres (Id,Name) Values(2,'Thriller')");
            Sql("INSERT INTO Genres (Id,Name) Values(3,'Family')");
            Sql("INSERT INTO Genres (Id,Name) Values(4,'Romance')");
            Sql("INSERT INTO Genres (Id,Name) Values(5,'Comedy')");
        }
        
        public override void Down()
        {
        }
    }
}
