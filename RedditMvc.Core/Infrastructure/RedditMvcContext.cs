using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RedditMvc.Core.Models;

namespace RedditMvc.Core.Infrastructure
{
    public class RedditMvcContext : DbContext
    {
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Artist>()
                        .HasMany<Genre>(s => s.Genres)
                        .WithMany(c => c.Artists)
                        .Map(cs =>
                        {
                            cs.MapLeftKey("ArtistId");
                            cs.MapRightKey("GenreId");
                            cs.ToTable("ArtistGenre");
                        });

        }
        public DbSet<Artist> Artists { get; set; }
        public DbSet<Genre> Genres { get; set; }
    }
}
