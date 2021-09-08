using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using RestApi.DbContexts;
using RestApi.Models.Address;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestApi.Controllers.Adress
{
    [Route("api/[controller]")]
    [ApiController]
    public class CtiesController : Controller
    {
        private MyDBContext myDbContext;

        public CtiesController(MyDBContext context)
        {
            myDbContext = context;
        }

        [HttpGet]
        public IList<Cties> Get()
        {
            return (myDbContext.Cties.ToList());
        }
        [HttpPost]
        public IActionResult Post(Cties cties)
        {
            myDbContext.Cties.Add(cties);
            myDbContext.SaveChanges();
            return Accepted();
        }

        [HttpPut]
        public IActionResult Put(Cties cties)
        {
            myDbContext.Cties.Update(cties);
            myDbContext.SaveChanges();
            return Accepted();
        }

        [HttpDelete]

        public IActionResult Delete(Cties cties)
        {
            myDbContext.Cties.Remove(cties);
            myDbContext.SaveChanges();
            return Accepted();
        }
    }
}
