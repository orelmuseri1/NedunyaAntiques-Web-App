namespace NedunyaAntiquesWebApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DateTimeToNull : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.AspNetUsers", "Birthdate", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.AspNetUsers", "Birthdate", c => c.DateTime(nullable: false));
        }
    }
}
