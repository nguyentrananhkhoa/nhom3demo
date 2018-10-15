namespace QLSV.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class test : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Lops",
                c => new
                    {
                        MaLop = c.String(nullable: false, maxLength: 128),
                        TenLop = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.MaLop);
            
            CreateTable(
                "dbo.SinhViens",
                c => new
                    {
                        MaSV = c.String(nullable: false, maxLength: 128),
                        HoTen = c.String(nullable: false, maxLength: 50),
                        DiaChi = c.String(),
                        TenLop = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.MaSV)
                .ForeignKey("dbo.Lops", t => t.TenLop)
                .Index(t => t.TenLop);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SinhViens", "TenLop", "dbo.Lops");
            DropIndex("dbo.SinhViens", new[] { "TenLop" });
            DropTable("dbo.SinhViens");
            DropTable("dbo.Lops");
        }
    }
}
