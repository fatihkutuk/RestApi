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
    public class CompanyGroupsController : ControllerBase
    {


        private systemDbContext systemDbContext;

        public CompanyGroupsController(systemDbContext context)
        {
            systemDbContext = context;
        }

        [HttpGet]
        public IList<CompanyGroups> Get()
        {
            return (this.systemDbContext.CompanyGroups.ToList());
        }

        [HttpGet("{Id}")]
        public CompanyGroups Get([FromRoute] int Id)
        {
            return (systemDbContext.CompanyGroups.Where(c => c.Id == Id).FirstOrDefault());
        }

        [HttpPost]
        public IActionResult Post(CompanyGroups companyGroups)
        {
            systemDbContext.CompanyGroups.Add(companyGroups);
            systemDbContext.SaveChanges();
            return Accepted();
        }

        [HttpPut]
        public IActionResult Put(CompanyGroups companyGroups)
        {
            systemDbContext.CompanyGroups.Update(companyGroups);
            systemDbContext.SaveChanges();
            return Accepted();
        }

        [HttpDelete]

        public IActionResult Delete(CompanyGroups companyGroups)
        {
            systemDbContext.CompanyGroups.Remove(companyGroups);
            systemDbContext.SaveChanges();
            return Accepted();
        }
    }
}
