using Microsoft.AspNetCore.Mvc;
using RestApi.DbContexts;
using RestApi.Models.Address;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestApi.Controllers.Adress
{
    [Route("api/[controller]")]
    [ApiController]
    public class CtiesController : Controller
    {
        private MyDBContext myDbContext;

        public CtiesController(MyDBContext context)
        {
            myDbContext = context;
        }

        [HttpGet]
        public IList<Cties> Get()
        {
            return (this.myDbContext.Cties.ToList());
        }
    }
}
