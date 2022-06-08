namespace FZMusicEntites.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class database2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.tblLikeMusic",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        User_id = c.Int(nullable: false),
                        Music_id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.tblMusic", t => t.Music_id, cascadeDelete: true)
                .ForeignKey("dbo.tblUser", t => t.User_id, cascadeDelete: true)
                .Index(t => t.User_id)
                .Index(t => t.Music_id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.tblLikeMusic", "User_id", "dbo.tblUser");
            DropForeignKey("dbo.tblLikeMusic", "Music_id", "dbo.tblMusic");
            DropIndex("dbo.tblLikeMusic", new[] { "Music_id" });
            DropIndex("dbo.tblLikeMusic", new[] { "User_id" });
            DropTable("dbo.tblLikeMusic");
        }
    }
}
