using Microsoft.AspNetCore.Mvc;
using RestApi.DbContexts;
using RestApi.Models.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestApi.Controllers.User
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : Controller
    {
        private MyDBContext myDbContext;

        public UsersController(MyDBContext context)
        {
            myDbContext = context;
        }

        [HttpGet]
        public IList<Users> Get()
        {
            return (this.myDbContext.Users.ToList());
        }
    }
}
