namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Genres : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Genres ( GenreName) VALUES ( 'Action')");
            Sql("INSERT INTO Genres ( GenreName) VALUES ( 'Thriller')");
            Sql("INSERT INTO Genres ( GenreName) VALUES ('Family')");
            Sql("INSERT INTO Genres ( GenreName) VALUES ( 'Romance')");
            Sql("INSERT INTO Genres ( GenreName) VALUES ('Comedy')");
        }
        
        public override void Down()
        {
        }
    }
}
