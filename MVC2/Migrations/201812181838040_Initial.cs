namespace MVC2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Couples",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Boy = c.String(),
                        Bride = c.String(),
                        Surname = c.String(),
                        RegistrationDay = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Variants",
                c => new
                    {
                        VariantId = c.Int(nullable: false, identity: true),
                        toustmuster = c.String(),
                        Musicion = c.String(),
                        Decor = c.String(),
                        CoupleID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.VariantId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Variants");
            DropTable("dbo.Couples");
        }
    }
}
