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
    public class CompanyWorksController : Controller
    {
        private systemDbContext systemDbContext;

        public CompanyWorksController(systemDbContext context)
        {
            systemDbContext = context;
        }

        [HttpGet]
        public IList<CompanyWorks> Get()
        {
            return (this.systemDbContext.CompanyWorks.ToList());
        }

        [HttpGet("{Id}")]
        public CompanyWorks Get([FromRoute] int Id)
        {
            return (systemDbContext.CompanyWorks.Where(c => c.Id == Id).FirstOrDefault());
        }

        [HttpPost]
        public IActionResult Post(CompanyWorks companyWorks)
        {
            systemDbContext.CompanyWorks.Add(companyWorks);
            systemDbContext.SaveChanges();
            return Accepted();
        }

        [HttpPut]
        public IActionResult Put(CompanyWorks companyWorks)
        {
            systemDbContext.CompanyWorks.Update(companyWorks);
            systemDbContext.SaveChanges();
            return Accepted();
        }

        [HttpDelete]

        public IActionResult Delete(CompanyWorks companyWorks)
        {
            systemDbContext.CompanyWorks.Remove(companyWorks);
            systemDbContext.SaveChanges();
            return Accepted();
        }
    }
}
