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
    public class CompanyCommentsController : Controller
    {
        private MyDBContext myDbContext;

        public CompanyCommentsController(MyDBContext context)
        {
            myDbContext = context;
        }

        [HttpGet]
        public IList<CompanyComments> Get()
        {
            return (this.myDbContext.CompanyComments.ToList());
        }
        [HttpPost]
        public IActionResult Post(CompanyComments companyComments)
        {
            myDbContext.CompanyComments.Add(companyComments);
            myDbContext.SaveChanges();
            return Accepted();
        }

        [HttpPut]
        public IActionResult Put(CompanyComments companyComments)
        {
            myDbContext.CompanyComments.Update(companyComments);
            myDbContext.SaveChanges();
            return Accepted();
        }

        [HttpDelete]

        public IActionResult Delete(CompanyComments companyComments)
        {
            myDbContext.CompanyComments.Remove(companyComments);
            myDbContext.SaveChanges();
            return Accepted();
        }
    }
}
