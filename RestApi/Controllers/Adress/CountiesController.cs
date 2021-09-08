using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.ChangeTracking;
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
    public class CountiesController : Controller
    {
        private MyDBContext myDbContext;

        public CountiesController(MyDBContext context)
        {
            myDbContext = context;
        }

        [HttpGet]
        public IList<Counties> Get()
        {
            return (this.myDbContext.Counties.ToList());
        }
        [HttpPost]
        public IActionResult Post(Counties counties)
        {
            myDbContext.Counties.Add(counties);
            myDbContext.SaveChanges();
            return Accepted();
        }

        [HttpPut]
        public IActionResult Put(Counties counties)
        {
            myDbContext.Counties.Update(counties);
            myDbContext.SaveChanges();
            return Accepted();
        }

        [HttpDelete]

        public IActionResult Delete(Counties counties)
        {
            myDbContext.Counties.Remove(counties);
            myDbContext.SaveChanges();
            return Accepted();
        }
    }
}
