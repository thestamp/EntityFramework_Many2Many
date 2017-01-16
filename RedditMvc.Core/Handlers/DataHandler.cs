using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RedditMvc.Core.Infrastructure;

namespace RedditMvc.Core.Handlers
{
    public class DataHandler
    {
        protected readonly RedditMvcContext _context;

        public DataHandler(RedditMvcContext context)
        {
            _context = context;
        }
    }
}
