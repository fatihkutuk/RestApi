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


        private MyDBContext myDbContext;

        public CompaniesController(MyDBContext context)
        {
            myDbContext = context;
        }

        [HttpGet]
        public IList<Companies> Get()
        {
            return (this.myDbContext.Companies.ToList());
        }
        [HttpPost]
        public IActionResult Post(Companies companies)
        {
            myDbContext.Companies.Add(companies);
            myDbContext.SaveChanges();
            return Accepted();
        }

        [HttpPut]
        public IActionResult Put(Companies companies)
        {
            myDbContext.Companies.Update(companies);
            myDbContext.SaveChanges();
            return Accepted();
        }

        [HttpDelete]

        public IActionResult Delete(Companies companies)
        {
            myDbContext.Companies.Remove(companies);
            myDbContext.SaveChanges();
            return Accepted();
        }
    }
}
