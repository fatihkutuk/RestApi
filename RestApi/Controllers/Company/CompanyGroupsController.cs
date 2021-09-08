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


        private MyDBContext myDbContext;

        public CompanyGroupsController(MyDBContext context)
        {
            myDbContext = context;
        }

        [HttpGet]
        public IList<CompanyGroups> Get()
        {
            return (this.myDbContext.CompanyGroups.ToList());
        }

        [HttpPost]
        public IActionResult Post(CompanyGroups companyGroups)
        {
            myDbContext.CompanyGroups.Add(companyGroups);
            myDbContext.SaveChanges();
            return Accepted();
        }

        [HttpPut]
        public IActionResult Put(CompanyGroups companyGroups)
        {
            myDbContext.CompanyGroups.Update(companyGroups);
            myDbContext.SaveChanges();
            return Accepted();
        }

        [HttpDelete]

        public IActionResult Delete(CompanyGroups companyGroups)
        {
            myDbContext.CompanyGroups.Remove(companyGroups);
            myDbContext.SaveChanges();
            return Accepted();
        }
    }
}
