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
    }
}
