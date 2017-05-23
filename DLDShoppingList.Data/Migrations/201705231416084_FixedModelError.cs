namespace DLDShoppingList.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FixedModelError : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.ShoppingListItemContext", "ShoppingListContextID", "dbo.ShoppingListContext");
            DropIndex("dbo.ShoppingListItemContext", new[] { "ShoppingListContextID" });
            CreateTable(
                "dbo.ShoppingList",
                c => new
                    {
                        ShoppingListID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Color = c.String(),
                        CreatedUtc = c.DateTimeOffset(nullable: false, precision: 7),
                        ModifiedUtc = c.DateTimeOffset(nullable: false, precision: 7),
                    })
                .PrimaryKey(t => t.ShoppingListID);
            
            CreateTable(
                "dbo.ShoppingListItem",
                c => new
                    {
                        ShoppingListItemID = c.Int(nullable: false, identity: true),
                        ShoppingListID = c.Int(nullable: false),
                        Contents = c.String(),
                        Note = c.String(),
                        Priority = c.Int(nullable: false),
                        IsChecked = c.Boolean(nullable: false),
                        CreatedUtc = c.DateTimeOffset(nullable: false, precision: 7),
                        ModifiedUtc = c.DateTimeOffset(nullable: false, precision: 7),
                    })
                .PrimaryKey(t => t.ShoppingListItemID)
                .ForeignKey("dbo.ShoppingList", t => t.ShoppingListID, cascadeDelete: true)
                .Index(t => t.ShoppingListID);
            
            DropTable("dbo.ShoppingListContext");
            DropTable("dbo.ShoppingListItemContext");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.ShoppingListItemContext",
                c => new
                    {
                        ShoppingListItemContextID = c.Int(nullable: false, identity: true),
                        ShoppingListContextID = c.Int(nullable: false),
                        Contents = c.String(),
                        Note = c.String(),
                        Priority = c.Int(nullable: false),
                        IsChecked = c.Boolean(nullable: false),
                        CreatedUtc = c.DateTimeOffset(nullable: false, precision: 7),
                        ModifiedUtc = c.DateTimeOffset(nullable: false, precision: 7),
                    })
                .PrimaryKey(t => t.ShoppingListItemContextID);
            
            CreateTable(
                "dbo.ShoppingListContext",
                c => new
                    {
                        ShoppingListContextID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Color = c.String(),
                        CreatedUtc = c.DateTimeOffset(nullable: false, precision: 7),
                        ModifiedUtc = c.DateTimeOffset(nullable: false, precision: 7),
                    })
                .PrimaryKey(t => t.ShoppingListContextID);
            
            DropForeignKey("dbo.ShoppingListItem", "ShoppingListID", "dbo.ShoppingList");
            DropIndex("dbo.ShoppingListItem", new[] { "ShoppingListID" });
            DropTable("dbo.ShoppingListItem");
            DropTable("dbo.ShoppingList");
            CreateIndex("dbo.ShoppingListItemContext", "ShoppingListContextID");
            AddForeignKey("dbo.ShoppingListItemContext", "ShoppingListContextID", "dbo.ShoppingListContext", "ShoppingListContextID", cascadeDelete: true);
        }
    }
}
