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
        private MyDBContext myDbContext;

        public CompanyWorksController(MyDBContext context)
        {
            myDbContext = context;
        }

        [HttpGet]
        public IList<CompanyWorks> Get()
        {
            return (this.myDbContext.CompanyWorks.ToList());
        }
        [HttpPost]
        public IActionResult Post(CompanyWorks companyWorks)
        {
            myDbContext.CompanyWorks.Add(companyWorks);
            myDbContext.SaveChanges();
            return Accepted();
        }

        [HttpPut]
        public IActionResult Put(CompanyWorks companyWorks)
        {
            myDbContext.CompanyWorks.Update(companyWorks);
            myDbContext.SaveChanges();
            return Accepted();
        }

        [HttpDelete]

        public IActionResult Delete(CompanyWorks companyWorks)
        {
            myDbContext.CompanyWorks.Remove(companyWorks);
            myDbContext.SaveChanges();
            return Accepted();
        }
    }
}
