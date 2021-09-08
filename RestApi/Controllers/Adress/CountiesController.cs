using Microsoft.AspNetCore.Mvc;
using RestApi.DbContexts;
using RestApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestApi.Controllers.Adress
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountiesController : Controller
    {
        private MyDBContext myDbContext;

        public CountiesController(MyDBContext context)
        {
            myDbContext = context;
        }

        [HttpGet]
        public IList<Counties> Get()
        {
            return (this.myDbContext.Counties.ToList());
        }
    }
}
