namespace ToDoList.DataAcccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class M1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Jobs",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        finishDate = c.DateTime(nullable: false, storeType: "date"),
                        description = c.String(nullable: false, maxLength: 4000),
                        statusId = c.Int(nullable: false),
                        userId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Statuses",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        Description = c.String(maxLength: 4000),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserName = c.String(maxLength: 4000),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Users");
            DropTable("dbo.Statuses");
            DropTable("dbo.Jobs");
        }
    }
}
