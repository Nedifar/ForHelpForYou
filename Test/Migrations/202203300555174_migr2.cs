namespace Test.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migr2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Genders",
                c => new
                    {
                        idGender = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.idGender);
            
            AddColumn("dbo.People", "idGender", c => c.Int(nullable: false));
            CreateIndex("dbo.People", "idGender");
            AddForeignKey("dbo.People", "idGender", "dbo.Genders", "idGender", cascadeDelete: true);
            DropColumn("dbo.People", "gender");
        }
        
        public override void Down()
        {
            AddColumn("dbo.People", "gender", c => c.String());
            DropForeignKey("dbo.People", "idGender", "dbo.Genders");
            DropIndex("dbo.People", new[] { "idGender" });
            DropColumn("dbo.People", "idGender");
            DropTable("dbo.Genders");
        }
    }
}
