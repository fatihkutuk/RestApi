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
    public class StreetsController : Controller
    {
        private MyDBContext myDbContext;

        public StreetsController(MyDBContext context)
        {
            myDbContext = context;
        }

        [HttpGet]
        public IList<Streets> Get()
        {
            return (this.myDbContext.Streets.ToList());
        }
    }
}
