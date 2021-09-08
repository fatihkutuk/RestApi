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
        [HttpPost]
        public IActionResult Post(Users users)
        {
            myDbContext.Users.Add(users);
            myDbContext.SaveChanges();
            return Accepted();
        }

        [HttpPut]
        public IActionResult Put(Users users)
        {
            myDbContext.Users.Update(users);
            myDbContext.SaveChanges();
            return Accepted();
        }

        [HttpDelete]

        public IActionResult Delete(Users users)
        {
            myDbContext.Users.Remove(users);
            myDbContext.SaveChanges();
            return Accepted();

        }
    }
}
