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
        private MyDBContext myDbContext;

        public CompanyAppointmentTimesController(MyDBContext context)
        {
            myDbContext = context;
        }

        [HttpGet]
        public IList<CompanyAppointmentTimes> Get()
        {
            return (this.myDbContext.CompanyAppointmentTimes.ToList());
        }
    }
}
