namespace TaskManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FirstMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Customer",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false, maxLength: 50),
                        LastName = c.String(nullable: false, maxLength: 50),
                        Company = c.String(maxLength: 100),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Request",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false, maxLength: 100),
                        Text = c.String(nullable: false),
                        Owner = c.Int(nullable: false),
                        ProjectId = c.Int(nullable: false),
                        RequestDate = c.DateTime(nullable: false),
                        RequestType = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Customer", t => t.Owner, cascadeDelete: true)
                .ForeignKey("dbo.Project", t => t.ProjectId, cascadeDelete: true)
                .Index(t => t.Owner)
                .Index(t => t.ProjectId);
            
            CreateTable(
                "dbo.Project",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 100),
                        Description = c.String(maxLength: 8000, unicode: false),
                        StartDate = c.DateTime(nullable: false, storeType: "date"),
                        EndDate = c.DateTime(nullable: false, storeType: "date"),
                        CompletedDate = c.DateTime(storeType: "date"),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Name, unique: true, name: "IX_ProjectName");
            
            CreateTable(
                "dbo.Task",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false, maxLength: 100),
                        Text = c.String(nullable: false),
                        RequestId = c.Int(),
                        CreationDate = c.DateTime(nullable: false),
                        AssignmentDate = c.DateTime(),
                        EstimatedDuration = c.Single(),
                        Deadline = c.DateTime(),
                        CompletedDate = c.DateTime(),
                        ProjectId = c.Int(),
                        AssignedTo = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Employee", t => t.AssignedTo)
                .ForeignKey("dbo.Project", t => t.ProjectId)
                .ForeignKey("dbo.Request", t => t.RequestId)
                .Index(t => t.RequestId)
                .Index(t => t.ProjectId)
                .Index(t => t.AssignedTo);
            
            CreateTable(
                "dbo.Employee",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false, maxLength: 50),
                        LastName = c.String(nullable: false, maxLength: 50),
                        DateOfBirth = c.DateTime(storeType: "date"),
                        Title = c.Byte(nullable: false),
                        Username = c.String(maxLength: 50),
                        Password = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Username, unique: true);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Request", "ProjectId", "dbo.Project");
            DropForeignKey("dbo.Task", "RequestId", "dbo.Request");
            DropForeignKey("dbo.Task", "ProjectId", "dbo.Project");
            DropForeignKey("dbo.Task", "AssignedTo", "dbo.Employee");
            DropForeignKey("dbo.Request", "Owner", "dbo.Customer");
            DropIndex("dbo.Employee", new[] { "Username" });
            DropIndex("dbo.Task", new[] { "AssignedTo" });
            DropIndex("dbo.Task", new[] { "ProjectId" });
            DropIndex("dbo.Task", new[] { "RequestId" });
            DropIndex("dbo.Project", "IX_ProjectName");
            DropIndex("dbo.Request", new[] { "ProjectId" });
            DropIndex("dbo.Request", new[] { "Owner" });
            DropTable("dbo.Employee");
            DropTable("dbo.Task");
            DropTable("dbo.Project");
            DropTable("dbo.Request");
            DropTable("dbo.Customer");
        }
    }
}
