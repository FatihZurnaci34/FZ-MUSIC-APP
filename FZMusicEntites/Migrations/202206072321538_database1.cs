namespace FZMusicEntites.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class database1 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.LikeMusics", "Music_Id", "dbo.tblMusic");
            DropForeignKey("dbo.LikeMusics", "User_Id", "dbo.tblUser");
            DropIndex("dbo.LikeMusics", new[] { "Music_Id" });
            DropIndex("dbo.LikeMusics", new[] { "User_Id" });
            DropTable("dbo.LikeMusics");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.LikeMusics",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        User_id = c.String(),
                        Music_id = c.Int(nullable: false),
                        Music_Id = c.Int(),
                        User_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateIndex("dbo.LikeMusics", "User_Id");
            CreateIndex("dbo.LikeMusics", "Music_Id");
            AddForeignKey("dbo.LikeMusics", "User_Id", "dbo.tblUser", "Id");
            AddForeignKey("dbo.LikeMusics", "Music_Id", "dbo.tblMusic", "Id");
        }
    }
}
