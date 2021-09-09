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
        private systemDbContext systemDbContext;

        public CountiesController(systemDbContext context)
        {
            systemDbContext = context;
        }

        [HttpGet]
        public IList<Counties> Get()
        {
            return (this.systemDbContext.Counties.ToList());
        }

        [HttpGet("{Id}")]
        public Counties Get([FromRoute] int Id)
        {
            return (systemDbContext.Counties.Where(c => c.Id == Id).FirstOrDefault());
        }

        [HttpPost]
        public IActionResult Post(Counties counties)
        {
            systemDbContext.Counties.Add(counties);
            systemDbContext.SaveChanges();
            return Accepted();
        }

        [HttpPut]
        public IActionResult Put(Counties counties)
        {
            systemDbContext.Counties.Update(counties);
            systemDbContext.SaveChanges();
            return Accepted();
        }

        [HttpDelete]

        public IActionResult Delete(Counties counties)
        {
            systemDbContext.Counties.Remove(counties);
            systemDbContext.SaveChanges();
            return Accepted();
        }
    }
}
