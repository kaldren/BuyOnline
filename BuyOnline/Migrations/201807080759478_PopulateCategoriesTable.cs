namespace BuyOnline.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateCategoriesTable : DbMigration
    {
        public override void Up()
        {
            Sql("SET IDENTITY_INSERT Categories ON");
            Sql("INSERT INTO Categories (Id, Name) VALUES (1, 'Computers')");
            Sql("INSERT INTO Categories (Id, Name) VALUES (2, 'Real Estate')");
            Sql("INSERT INTO Categories (Id, Name) VALUES (3, 'Cosmetics')");
            Sql("INSERT INTO Categories (Id, Name) VALUES (4, 'Clothes')");
            Sql("SET IDENTITY_INSERT Categories OFF");
        }

        public override void Down()
        {
            Sql("DELETE FROM Categories WHERE Id IN (1, 2, 3, 4)");
        }
    }
}
