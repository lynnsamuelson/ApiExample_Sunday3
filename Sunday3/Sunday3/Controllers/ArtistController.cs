using Sunday3.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;

namespace Sunday3.Controllers
{
    public class ArtistController : ApiController
    {

        public ApplicationDbContext dbContext = new ApplicationDbContext();
        public ArtistController()
        {
        }
        //public ArtistController(ApplicationDbContext context)
        //{
        //    dbContext = context;
        //}

        [System.Web.Http.HttpGet]
        public IEnumerable Get()
        {
            var products = dbContext.Artist;
            yield return Json(products);
        }
        // GET: api/Artist
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "Artist1", "Artist2" };
        //}

        // GET: api/Artist/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Artist
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Artist/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Artist/5
        public void Delete(int id)
        {
        }
    }
}
