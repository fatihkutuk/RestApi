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
    public class NeighborhoodsController : Controller
    {
        private MyDBContext myDbContext;

        public NeighborhoodsController(MyDBContext context)
        {
            myDbContext = context;
        }

        [HttpGet]
        public IList<Neighborhood> Get()
        {
            return (this.myDbContext.Neighborhoods.ToList());
        }
    }
}
