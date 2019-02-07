namespace FaturaProje.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateColumnsAllTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Urun", "BirimID", c => c.String());
            CreateIndex("dbo.FaturaMaster", "MusteriID");
            AddForeignKey("dbo.FaturaMaster", "MusteriID", "dbo.Musteri", "MusteriID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.FaturaMaster", "MusteriID", "dbo.Musteri");
            DropIndex("dbo.FaturaMaster", new[] { "MusteriID" });
            DropColumn("dbo.Urun", "BirimID");
        }
    }
}
