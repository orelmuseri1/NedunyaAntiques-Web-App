namespace NedunyaAntiquesWebApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class LogIn : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.AspNetUsers", "ReturnUrl");
            DropColumn("dbo.AspNetUsers", "Discriminator");
        }
        
        public override void Down()
        {
            AddColumn("dbo.AspNetUsers", "Discriminator", c => c.String(nullable: false, maxLength: 128));
            AddColumn("dbo.AspNetUsers", "ReturnUrl", c => c.String());
        }
    }
}
