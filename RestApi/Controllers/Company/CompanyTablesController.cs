using Microsoft.AspNetCore.Mvc;
using RestApi.DbContexts;
using RestApi.Models.Company;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestApi.Controllers.Company
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyTablesController : Controller
    {
        private systemDbContext systemDbContext;

        public CompanyTablesController(systemDbContext context)
        {
            systemDbContext = context;
        }

        [HttpGet]
        public IList<CompanyTables> Get()
        {
            return (this.systemDbContext.CompanyTables.ToList());
        }

        [HttpGet("{Id}")]
        public CompanyTables Get([FromRoute] int Id)
        {
            return (systemDbContext.CompanyTables.Where(c => c.Id == Id).FirstOrDefault());
        }

        [HttpPost]
        public IActionResult Post(CompanyTables companyTables)
        {
            systemDbContext.CompanyTables.Add(companyTables);
            systemDbContext.SaveChanges();
            return Accepted();
        }

        [HttpPut]
        public IActionResult Put(CompanyTables companyTables)
        {
            systemDbContext.CompanyTables.Update(companyTables);
            systemDbContext.SaveChanges();
            return Accepted();
        }

        [HttpDelete]

        public IActionResult Delete(CompanyTables companyTables)
        {
            systemDbContext.CompanyTables.Remove(companyTables);
            systemDbContext.SaveChanges();
            return Accepted();
        }
    }
}
