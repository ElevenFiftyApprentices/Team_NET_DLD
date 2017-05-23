namespace DLDShoppingList.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.ShoppingListItemContext", "ShoppingListContextID");
            AddForeignKey("dbo.ShoppingListItemContext", "ShoppingListContextID", "dbo.ShoppingListContext", "ShoppingListContextID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ShoppingListItemContext", "ShoppingListContextID", "dbo.ShoppingListContext");
            DropIndex("dbo.ShoppingListItemContext", new[] { "ShoppingListContextID" });
        }
    }
}
