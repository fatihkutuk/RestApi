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
    }
}
