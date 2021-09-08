using Microsoft.AspNetCore.Mvc;
using RestApi.DbContexts;
using RestApi.Models;
using RestApi.Models.Address;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestApi.Controllers.Adress
{
    [Route("api/[controller]")]
    [ApiController]
    public class NeighborhoodsController : Controller
    {
        private MyDBContext myDbContext;

        public NeighborhoodsController(MyDBContext context)
        {
            myDbContext = context;
        }

        [HttpGet]
        public IList<Neighborhood> Get()
        {
            return (this.myDbContext.Neighborhoods.ToList());
        }
        [HttpPost]
        public IActionResult Post(Neighborhood neighborhood)
        {
            myDbContext.Neighborhoods.Add(neighborhood);
            myDbContext.SaveChanges();
            return Accepted();
        }

        [HttpPut]
        public IActionResult Put(Neighborhood neighborhood)
        {
            myDbContext.Neighborhoods.Update(neighborhood);
            myDbContext.SaveChanges();
            return Accepted();
        }

        [HttpDelete]

        public IActionResult Delete(Neighborhood neighborhood)
        {
            myDbContext.Neighborhoods.Remove(neighborhood);
            myDbContext.SaveChanges();
            return Accepted();
        }
    }
}
