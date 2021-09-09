using Microsoft.AspNetCore.Mvc;
using RestApi.DbContexts;
using RestApi.Models;
using RestApi.Models.Company;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestApi.Controllers.Company
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompaniesController : ControllerBase
    {


        private systemDbContext systemDbContext;

        public CompaniesController(systemDbContext context)
        {
            systemDbContext = context;
        }

        [HttpGet]
        public IList<Companies> Get()
        {
            return (this.systemDbContext.Companies.ToList());
        }

        [HttpGet("{Id}")]
        public Companies Get([FromRoute] int Id)
        {
            return (systemDbContext.Companies.Where(c => c.Id == Id).FirstOrDefault());
        }

        [HttpPost]
        public IActionResult Post(Companies companies)
        {
            systemDbContext.Companies.Add(companies);
            systemDbContext.SaveChanges();
            return Accepted();
        }

        [HttpPut]
        public IActionResult Put(Companies companies)
        {
            systemDbContext.Companies.Update(companies);
            systemDbContext.SaveChanges();
            return Accepted();
        }

        [HttpDelete]

        public IActionResult Delete(Companies companies)
        {
            systemDbContext.Companies.Remove(companies);
            systemDbContext.SaveChanges();
            return Accepted();
        }
    }
}
