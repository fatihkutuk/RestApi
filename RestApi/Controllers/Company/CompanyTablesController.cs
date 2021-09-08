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
    public class CompanyTablesController : Controller
    {
        private MyDBContext myDbContext;

        public CompanyTablesController(MyDBContext context)
        {
            myDbContext = context;
        }

        [HttpGet]
        public IList<CompanyTables> Get()
        {
            return (this.myDbContext.CompanyTables.ToList());
        }
    }
}
