namespace TrashCollector.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mymigration2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.DaysofWeeks",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Monday = c.String(),
                        Tuesday = c.String(),
                        Wednesday = c.String(),
                        Thursday = c.String(),
                        Friday = c.String(),
                        CustomerId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Clients", t => t.CustomerId, cascadeDelete: true)
                .Index(t => t.CustomerId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.DaysofWeeks", "CustomerId", "dbo.Clients");
            DropIndex("dbo.DaysofWeeks", new[] { "CustomerId" });
            DropTable("dbo.DaysofWeeks");
        }
    }
}
