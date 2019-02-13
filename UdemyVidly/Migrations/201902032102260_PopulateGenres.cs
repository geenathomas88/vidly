namespace UdemyVidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateGenres : DbMigration
    {
        public override void Up()
        {
            Sql("Insert into Genres (Id, Name) values (1, 'Comedy')");
            Sql("Insert into Genres (Id, Name) values (2, 'Fantasy')");
            Sql("Insert into Genres (Id, Name) values (3, 'Kids')");
            Sql("Insert into Genres (Id, Name) values (4, 'Feel Good')");
            Sql("Insert into Genres (Id, Name) values (5, 'Thriller')");
        }
        
        public override void Down()
        {
        }
    }
}
