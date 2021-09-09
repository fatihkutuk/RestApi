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
        private systemDbContext systemDbContext;

        public StreetsController(systemDbContext context)
        {
            systemDbContext = context;
        }

        [HttpGet]
        public IList<Streets> Get()
        {
            return (this.systemDbContext.Streets.ToList());
        }

        [HttpGet("{Id}")]
        public Streets Get([FromRoute] int Id)
        {
            return (systemDbContext.Streets.Where(c => c.Id == Id).FirstOrDefault());
        }

        [HttpPost]
        public IActionResult Post(Streets streets)
        {
            systemDbContext.Streets.Add(streets);
            systemDbContext.SaveChanges();
            return Accepted();
        }

        [HttpPut]
        public IActionResult Put(Streets streets)
        {
            systemDbContext.Streets.Update(streets);
            systemDbContext.SaveChanges();
            return Accepted();
        }

        [HttpDelete]

        public IActionResult Delete(Streets streets)
        {
            systemDbContext.Streets.Remove(streets);
            systemDbContext.SaveChanges();
            return Accepted();
        }
    }
}
