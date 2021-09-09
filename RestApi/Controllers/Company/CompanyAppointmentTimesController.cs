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
    public class CompanyAppointmentTimesController : Controller
    {
        private systemDbContext systemDbContext;

        public CompanyAppointmentTimesController(systemDbContext context)
        {
            systemDbContext = context;
        }

        [HttpGet]
        public IList<CompanyAppointmentTimes> Get()
        {
            return (this.systemDbContext.CompanyAppointmentTimes.ToList());
        }

        [HttpGet("{Id}")]
        public CompanyAppointmentTimes Get([FromRoute] int Id)
        {
            return (systemDbContext.CompanyAppointmentTimes.Where(c => c.Id == Id).FirstOrDefault());
        }

        [HttpPost]
        public IActionResult Post(CompanyAppointmentTimes companyAppointmentTimes)
        {
            systemDbContext.CompanyAppointmentTimes.Add(companyAppointmentTimes);
            systemDbContext.SaveChanges();
            return Accepted();
        }

        [HttpPut]
        public IActionResult Put(CompanyAppointmentTimes companyAppointmentTimes)
        {
            systemDbContext.CompanyAppointmentTimes.Update(companyAppointmentTimes);
            systemDbContext.SaveChanges();
            return Accepted();
        }

        [HttpDelete]

        public IActionResult Delete(CompanyAppointmentTimes companyAppointmentTimes)
        {
            systemDbContext.CompanyAppointmentTimes.Remove(companyAppointmentTimes);
            systemDbContext.SaveChanges();
            return Accepted();
        }
    }
}
