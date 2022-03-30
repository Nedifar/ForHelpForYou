namespace Test.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migr1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.People",
                c => new
                    {
                        idPeople = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Age = c.Int(nullable: false),
                        gender = c.String(),
                    })
                .PrimaryKey(t => t.idPeople);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.People");
        }
    }
}
