namespace Day1452024.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialModel : DbMigration
    {
        public override void Up()
        {
            /*CreateTable(
                "dbo.Authors",
                c => new
                    {
                        AuthorId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.AuthorId);
            
            CreateTable(
                "dbo.Courses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Description = c.String(nullable: false),
                        FullPrice = c.Single(nullable: false),
                        Author_id = c.Int(),
                        DatePublished = c.DateTime(),
                        Name = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Authors", t => t.Author_id)
                .Index(t => t.Author_id);
            
            CreateTable(
                "dbo.Tags",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.TagCourses",
                c => new
                    {
                        Course_Id = c.Int(nullable: false),
                        Tag_id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Course_Id, t.Tag_id })
                .ForeignKey("dbo.Courses", t => t.Course_Id, cascadeDelete: true)
                .ForeignKey("dbo.Tags", t => t.Tag_id, cascadeDelete: true)
                .Index(t => t.Course_Id)
                .Index(t => t.Tag_id);  */
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Courses", "Author_id", "dbo.Authors");
            DropForeignKey("dbo.TagCourses", "Tag_id", "dbo.Tags");
            DropForeignKey("dbo.TagCourses", "Course_Id", "dbo.Courses");
            DropIndex("dbo.TagCourses", new[] { "Tag_id" });
            DropIndex("dbo.TagCourses", new[] { "Course_Id" });
            DropIndex("dbo.Courses", new[] { "Author_id" });
            DropTable("dbo.TagCourses");
            DropTable("dbo.Tags");
            DropTable("dbo.Courses");
            DropTable("dbo.Authors");
        }
    }
}
