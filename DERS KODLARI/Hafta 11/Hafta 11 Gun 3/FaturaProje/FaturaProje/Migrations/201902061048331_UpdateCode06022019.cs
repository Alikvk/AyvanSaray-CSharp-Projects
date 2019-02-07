namespace FaturaProje.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateCode06022019 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Urun", "Birim_BirimID", "dbo.Birim");
            DropIndex("dbo.Urun", new[] { "Birim_BirimID" });
            DropColumn("dbo.Urun", "BirimID");
            RenameColumn(table: "dbo.Urun", name: "Birim_BirimID", newName: "BirimID");
            AlterColumn("dbo.Urun", "BirimID", c => c.Int(nullable: false));
            AlterColumn("dbo.Urun", "BirimID", c => c.Int(nullable: false));
            CreateIndex("dbo.Urun", "BirimID");
            AddForeignKey("dbo.Urun", "BirimID", "dbo.Birim", "BirimID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Urun", "BirimID", "dbo.Birim");
            DropIndex("dbo.Urun", new[] { "BirimID" });
            AlterColumn("dbo.Urun", "BirimID", c => c.Int());
            AlterColumn("dbo.Urun", "BirimID", c => c.String());
            RenameColumn(table: "dbo.Urun", name: "BirimID", newName: "Birim_BirimID");
            AddColumn("dbo.Urun", "BirimID", c => c.String());
            CreateIndex("dbo.Urun", "Birim_BirimID");
            AddForeignKey("dbo.Urun", "Birim_BirimID", "dbo.Birim", "BirimID");
        }
    }
}
