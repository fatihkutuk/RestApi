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
        private systemDbContext systemDbContext;

        public UsersController(systemDbContext context)
        {
            systemDbContext = context;
        }

        [HttpGet]
        public IList<Users> Get()
        {
            return (this.systemDbContext.Users.ToList());
        }

        [HttpGet("{Id}")]
        public Users Get([FromRoute] int Id)
        {
            return (systemDbContext.Users.Where(c => c.Id == Id).FirstOrDefault());
        }

        [HttpPost]
        public IActionResult Post(Users users)
        {
            systemDbContext.Users.Add(users);
            systemDbContext.SaveChanges();
            return Accepted();
        }

        [HttpPut]
        public IActionResult Put(Users users)
        {
            systemDbContext.Users.Update(users);
            systemDbContext.SaveChanges();
            return Accepted();
        }

        [HttpDelete]

        public IActionResult Delete(Users users)
        {
            systemDbContext.Users.Remove(users);
            systemDbContext.SaveChanges();
            return Accepted();

        }
    }
}
