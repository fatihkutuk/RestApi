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
        private MyDBContext myDbContext;

        public CompanyImagesController(MyDBContext context)
        {
            myDbContext = context;
        }

        [HttpGet]
        public IList<CompanyImages> Get()
        {
            return (this.myDbContext.CompanyImages.ToList());
        }
    }
}
