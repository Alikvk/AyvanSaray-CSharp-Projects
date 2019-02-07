namespace FaturaProje.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initializer : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Birim",
                c => new
                    {
                        BirimID = c.Int(nullable: false, identity: true),
                        Adi = c.String(),
                    })
                .PrimaryKey(t => t.BirimID);
            
            CreateTable(
                "dbo.Ilce",
                c => new
                    {
                        IlceID = c.Int(nullable: false, identity: true),
                        Aciklama = c.String(),
                        IlID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.IlceID)
                .ForeignKey("dbo.Il", t => t.IlID, cascadeDelete: true)
                .Index(t => t.IlID);
            
            CreateTable(
                "dbo.Il",
                c => new
                    {
                        IlID = c.Int(nullable: false, identity: true),
                        Aciklama = c.String(),
                    })
                .PrimaryKey(t => t.IlID);
            
            CreateTable(
                "dbo.Musteri",
                c => new
                    {
                        MusteriID = c.Int(nullable: false, identity: true),
                        MusteriUnvani = c.String(),
                        IlceID = c.Int(nullable: false),
                        MusteriAdresi = c.String(),
                    })
                .PrimaryKey(t => t.MusteriID)
                .ForeignKey("dbo.Ilce", t => t.IlceID, cascadeDelete: true)
                .Index(t => t.IlceID);
            
            CreateTable(
                "dbo.Urun",
                c => new
                    {
                        UrunID = c.Int(nullable: false, identity: true),
                        UrunAdi = c.String(),
                        UrunKodu = c.String(),
                        BirimFiyati = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Birim_BirimID = c.Int(),
                    })
                .PrimaryKey(t => t.UrunID)
                .ForeignKey("dbo.Birim", t => t.Birim_BirimID)
                .Index(t => t.Birim_BirimID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Urun", "Birim_BirimID", "dbo.Birim");
            DropForeignKey("dbo.Musteri", "IlceID", "dbo.Ilce");
            DropForeignKey("dbo.Ilce", "IlID", "dbo.Il");
            DropIndex("dbo.Urun", new[] { "Birim_BirimID" });
            DropIndex("dbo.Musteri", new[] { "IlceID" });
            DropIndex("dbo.Ilce", new[] { "IlID" });
            DropTable("dbo.Urun");
            DropTable("dbo.Musteri");
            DropTable("dbo.Il");
            DropTable("dbo.Ilce");
            DropTable("dbo.Birim");
        }
    }
}
