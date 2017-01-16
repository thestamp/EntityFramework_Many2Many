namespace RedditMvc.Core.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class m2m : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ArtistGenre",
                c => new
                    {
                        ArtistId = c.Int(nullable: false),
                        GenreId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.ArtistId, t.GenreId })
                .ForeignKey("dbo.Artists", t => t.ArtistId, cascadeDelete: true)
                .ForeignKey("dbo.Genres", t => t.GenreId, cascadeDelete: true)
                .Index(t => t.ArtistId)
                .Index(t => t.GenreId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ArtistGenre", "GenreId", "dbo.Genres");
            DropForeignKey("dbo.ArtistGenre", "ArtistId", "dbo.Artists");
            DropIndex("dbo.ArtistGenre", new[] { "GenreId" });
            DropIndex("dbo.ArtistGenre", new[] { "ArtistId" });
            DropTable("dbo.ArtistGenre");
        }
    }
}
