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
        private systemDbContext systemDbContext;

        public NeighborhoodsController(systemDbContext context)
        {
            systemDbContext = context;
        }

        [HttpGet]
        public IList<Neighborhood> Get()
        {
            return (this.systemDbContext.Neighborhoods.ToList());
        }

        [HttpGet("{Id}")]
        public Neighborhood Get([FromRoute] int Id)
        {
            return (systemDbContext.Neighborhoods.Where(c => c.Id == Id).FirstOrDefault());
        }

        [HttpPost]
        public IActionResult Post(Neighborhood neighborhood)
        {
            systemDbContext.Neighborhoods.Add(neighborhood);
            systemDbContext.SaveChanges();
            return Accepted();
        }

        [HttpPut]
        public IActionResult Put(Neighborhood neighborhood)
        {
            systemDbContext.Neighborhoods.Update(neighborhood);
            systemDbContext.SaveChanges();
            return Accepted();
        }

        [HttpDelete]

        public IActionResult Delete(Neighborhood neighborhood)
        {
            systemDbContext.Neighborhoods.Remove(neighborhood);
            systemDbContext.SaveChanges();
            return Accepted();
        }
    }
}
