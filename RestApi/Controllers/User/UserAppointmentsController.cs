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
    public class UserAppointmentsController : Controller
    {
        private systemDbContext systemDbContext;

        public UserAppointmentsController(systemDbContext context)
        {
            systemDbContext = context;
        }

        [HttpGet]
        public IList<UserAppointments> Get()
        {
            return (this.systemDbContext.UserAppointments.ToList());
        }

        [HttpGet("{Id}")]
        public UserAppointments Get([FromRoute] int Id)
        {
            return (systemDbContext.UserAppointments.Where(c => c.Id == Id).FirstOrDefault());
        }

        [HttpPost]
        public IActionResult Post(UserAppointments userAppointments)
        {
            systemDbContext.UserAppointments.Add(userAppointments);
            systemDbContext.SaveChanges();
            return Accepted();
        }

        [HttpPut]
        public IActionResult Put(UserAppointments userAppointments)
        {
            systemDbContext.UserAppointments.Update(userAppointments);
            systemDbContext.SaveChanges();
            return Accepted();
        }

        [HttpDelete]

        public IActionResult Delete(UserAppointments userAppointments)
        {
            systemDbContext.UserAppointments.Remove(userAppointments);
            systemDbContext.SaveChanges();
            return Accepted();
        }
    }
}
