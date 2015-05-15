namespace HDServices.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Teacher",
                c => new
                    {
                        ID = c.Int(nullable: false),
                        TeacherCode = c.String(nullable: false, maxLength: 50),
                        ClassID = c.String(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Person", t => t.ID)
                .Index(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Teacher", "ID", "dbo.Person");
            DropIndex("dbo.Teacher", new[] { "ID" });
            DropTable("dbo.Teacher");
        }
    }
}
