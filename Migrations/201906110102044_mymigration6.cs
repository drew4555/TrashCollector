namespace TrashCollector.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mymigration6 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Clients", "Suspend_Service_Start", c => c.String());
            AddColumn("dbo.Clients", "Suspend_Service_End", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Clients", "Suspend_Service_End");
            DropColumn("dbo.Clients", "Suspend_Service_Start");
        }
    }
}
