namespace DrinksDataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialDBCreation : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Ingredients",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Color = c.String(),
                        Percent = c.Int(),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Drinks",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Glass = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Items",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Amount = c.Int(nullable: false),
                        Unit = c.String(),
                        Ingredient_Id = c.Int(),
                        Drink_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Ingredients", t => t.Ingredient_Id)
                .ForeignKey("dbo.Drinks", t => t.Drink_Id)
                .Index(t => t.Ingredient_Id)
                .Index(t => t.Drink_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Items", "Drink_Id", "dbo.Drinks");
            DropForeignKey("dbo.Items", "Ingredient_Id", "dbo.Ingredients");
            DropIndex("dbo.Items", new[] { "Drink_Id" });
            DropIndex("dbo.Items", new[] { "Ingredient_Id" });
            DropTable("dbo.Items");
            DropTable("dbo.Drinks");
            DropTable("dbo.Ingredients");
        }
    }
}
