using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
        private readonly systemDbContext systemDbContext;

        public CtiesController(systemDbContext context)
        {
            systemDbContext = context;
        }

        [HttpGet("{Id}")]
        public Cties Get([FromRoute] int Id)
        {
            return (systemDbContext.Cties.Where(c => c.Id == Id).FirstOrDefault());   
        }

        [HttpGet]
        public IList<Cties> Get()
        {
            return (systemDbContext.Cties.ToList());
        }

        [HttpPost]
        public IActionResult Post(Cties cties)
        {
            systemDbContext.Cties.Add(cties);
            systemDbContext.SaveChanges();
            return Accepted();
        }

        [HttpPut]
        public IActionResult Put(Cties cties)
        {
            systemDbContext.Cties.Update(cties);
            systemDbContext.SaveChanges();
            return Accepted();
        }

        [HttpDelete]

        public IActionResult Delete(Cties cties)
        {
            systemDbContext.Cties.Remove(cties);
            systemDbContext.SaveChanges();
            return Accepted();
        }
    }
}
