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
    public class CompanyGroupsController : ControllerBase
    {


        private MyDBContext myDbContext;

        public CompanyGroupsController(MyDBContext context)
        {
            myDbContext = context;
        }

        [HttpGet]
        public IList<CompanyGroups> Get()
        {
            return (this.myDbContext.CompanyGroups.ToList());
        }
    }
}
