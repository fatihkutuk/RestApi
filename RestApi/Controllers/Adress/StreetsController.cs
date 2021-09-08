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
    public class StreetsController : Controller
    {
        private MyDBContext myDbContext;

        public StreetsController(MyDBContext context)
        {
            myDbContext = context;
        }

        [HttpGet]
        public IList<Streets> Get()
        {
            return (this.myDbContext.Streets.ToList());
        }
        [HttpPost]
        public IActionResult Post(Streets streets)
        {
            myDbContext.Streets.Add(streets);
            myDbContext.SaveChanges();
            return Accepted();
        }

        [HttpPut]
        public IActionResult Put(Streets streets)
        {
            myDbContext.Streets.Update(streets);
            myDbContext.SaveChanges();
            return Accepted();
        }

        [HttpDelete]

        public IActionResult Delete(Streets streets)
        {
            myDbContext.Streets.Remove(streets);
            myDbContext.SaveChanges();
            return Accepted();
        }
    }
}
