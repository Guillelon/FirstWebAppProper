namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingBranch : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Branches",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Manager = c.String(),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Bikes", "Color", c => c.String());
            AddColumn("dbo.Bikes", "BranchId", c => c.Int(nullable: false));
            AddColumn("dbo.Cars", "BranchId", c => c.Int(nullable: false));
            CreateIndex("dbo.Bikes", "BranchId");
            CreateIndex("dbo.Cars", "BranchId");
            AddForeignKey("dbo.Bikes", "BranchId", "dbo.Branches", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Cars", "BranchId", "dbo.Branches", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Cars", "BranchId", "dbo.Branches");
            DropForeignKey("dbo.Bikes", "BranchId", "dbo.Branches");
            DropIndex("dbo.Cars", new[] { "BranchId" });
            DropIndex("dbo.Bikes", new[] { "BranchId" });
            DropColumn("dbo.Cars", "BranchId");
            DropColumn("dbo.Bikes", "BranchId");
            DropColumn("dbo.Bikes", "Color");
            DropTable("dbo.Branches");
        }
    }
}
