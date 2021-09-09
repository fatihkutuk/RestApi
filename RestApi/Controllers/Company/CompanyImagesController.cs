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
    public class CompanyImagesController : Controller
    {
        private systemDbContext systemDbContext;

        public CompanyImagesController(systemDbContext context)
        {
            systemDbContext = context;
        }

        [HttpGet]
        public IList<CompanyImages> Get()
        {
            return (this.systemDbContext.CompanyImages.ToList());
        }

        [HttpGet("{Id}")]
        public CompanyImages Get([FromRoute] int Id)
        {
            return (systemDbContext.CompanyImages.Where(c => c.Id == Id).FirstOrDefault());
        }

        [HttpPost]
        public IActionResult Post(CompanyImages companyImages)
        {
            systemDbContext.CompanyImages.Add(companyImages);
            systemDbContext.SaveChanges();
            return Accepted();
        }

        [HttpPut]
        public IActionResult Put(CompanyImages companyImages)
        {
            systemDbContext.CompanyImages.Update(companyImages);
            systemDbContext.SaveChanges();
            return Accepted();
        }

        [HttpDelete]

        public IActionResult Delete(CompanyImages companyImages)
        {
            systemDbContext.CompanyImages.Remove(companyImages);
            systemDbContext.SaveChanges();
            return Accepted();
        }
    }
}
