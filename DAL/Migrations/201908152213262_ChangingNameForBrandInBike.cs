namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangingNameForBrandInBike : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Bikes", "Brand", c => c.String());
            DropColumn("dbo.Bikes", "Name");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Bikes", "Name", c => c.String());
            DropColumn("dbo.Bikes", "Brand");
        }
    }
}
