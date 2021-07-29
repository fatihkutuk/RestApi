using Microsoft.AspNetCore.Mvc;
using RestApi.DbContexts;
using RestApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestApi.Controllers
{
    public class CompaniesController : Controller
    {
        [Route("api/[controller]")]
        [ApiController]
        public class UserController : ControllerBase
        {
            private MyDBContext myDbContext;

            public UserController(MyDBContext context)
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
}
