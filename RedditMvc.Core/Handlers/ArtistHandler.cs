using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RedditMvc.Core.Infrastructure;
using RedditMvc.Core.Models;

namespace RedditMvc.Core.Handlers
{
    public class ArtistHandler:DataHandler
    {
        public ArtistHandler(RedditMvcContext context) : base(context)
        {
        }

        public IQueryable<Artist> GetArtists(string name)
        {
            return _context.Artists.AsQueryable().Where(i => i.Name.Contains(name));
        }

      
    }
}
