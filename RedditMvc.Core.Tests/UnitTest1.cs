using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RedditMvc.Core.Handlers;
using RedditMvc.Core.Infrastructure;


namespace RedditMvc.Core.Tests
{
    /// <summary>
    /// Jeff Lefebvre - TheDailyDeveloper.com
    /// MIT License 2017
    /// Enjoy!
    /// </summary>
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var name = "Rock";
            var context = new RedditMvcContext();
            var handler = new ArtistHandler(context);
            var artists = handler.GetArtists(name);

            Assert.IsTrue(artists.Any());//query is performed on this line :D
        }

        [TestMethod]
        public void TestRockMcJazz()
        {
            var name = "Rock McJazz";
            var context = new RedditMvcContext();
            var handler = new ArtistHandler(context);
            var artists = handler.GetArtists(name);
            var artist = artists.First(); //will throw exception if not found. 
            //var artist = artists.FirstOrDefault(); //will NOT throw exception if not found, just set to null. 

            Assert.IsTrue(artist.Genres.Count == 2);
            Assert.IsTrue(artist.Genres.Any(i => i.Name == "Rock"));
            Assert.IsTrue(artist.Genres.Any(i => i.Name == "Jazz"));
        }
    }
}
