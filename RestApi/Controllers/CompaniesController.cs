using Microsoft.AspNetCore.Mvc;
using RestApi.DbContexts;
using RestApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestApi.Controllers
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
    }
}
