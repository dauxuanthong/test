namespace Database_3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ProductTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        ProId = c.Int(nullable: false, identity: true),
                        ProName = c.String(nullable: false),
                        Price = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ProId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Products");
        }
    }
}
