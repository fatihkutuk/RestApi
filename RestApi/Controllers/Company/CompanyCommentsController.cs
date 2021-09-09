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
        private systemDbContext systemDbContext;

        public CompanyCommentsController(systemDbContext context)
        {
            systemDbContext = context;
        }

        [HttpGet]
        public IList<CompanyComments> Get()
        {
            return (this.systemDbContext.CompanyComments.ToList());
        }

        [HttpGet("{Id}")]
        public CompanyComments Get([FromRoute] int Id)
        {
            return (systemDbContext.CompanyComments.Where(c => c.Id == Id).FirstOrDefault());
        }

        [HttpPost]
        public IActionResult Post(CompanyComments companyComments)
        {
            systemDbContext.CompanyComments.Add(companyComments);
            systemDbContext.SaveChanges();
            return Accepted();
        }

        [HttpPut]
        public IActionResult Put(CompanyComments companyComments)
        {
            systemDbContext.CompanyComments.Update(companyComments);
            systemDbContext.SaveChanges();
            return Accepted();
        }

        [HttpDelete]

        public IActionResult Delete(CompanyComments companyComments)
        {
            systemDbContext.CompanyComments.Remove(companyComments);
            systemDbContext.SaveChanges();
            return Accepted();
        }
    }
}
