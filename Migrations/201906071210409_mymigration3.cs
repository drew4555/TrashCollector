namespace TrashCollector.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mymigration3 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.DaysofWeeks", "Day", c => c.String());
            DropColumn("dbo.DaysofWeeks", "Monday");
            DropColumn("dbo.DaysofWeeks", "Tuesday");
            DropColumn("dbo.DaysofWeeks", "Wednesday");
            DropColumn("dbo.DaysofWeeks", "Thursday");
            DropColumn("dbo.DaysofWeeks", "Friday");
        }
        
        public override void Down()
        {
            AddColumn("dbo.DaysofWeeks", "Friday", c => c.String());
            AddColumn("dbo.DaysofWeeks", "Thursday", c => c.String());
            AddColumn("dbo.DaysofWeeks", "Wednesday", c => c.String());
            AddColumn("dbo.DaysofWeeks", "Tuesday", c => c.String());
            AddColumn("dbo.DaysofWeeks", "Monday", c => c.String());
            DropColumn("dbo.DaysofWeeks", "Day");
        }
    }
}
