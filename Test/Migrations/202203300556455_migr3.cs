namespace Test.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migr3 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.People", "Login", c => c.String());
            AddColumn("dbo.People", "pwd", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.People", "pwd");
            DropColumn("dbo.People", "Login");
        }
    }
}
