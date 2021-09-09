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
    public class UserAppointmentsSelectedWorksController : Controller
    {
        private systemDbContext systemDbContext;

        public UserAppointmentsSelectedWorksController(systemDbContext context)
        {
            systemDbContext = context;
        }

        [HttpGet]
        public IList<UserAppointmentsSelectedWorks> Get()
        {
            return (this.systemDbContext.UserAppointmentsSelectedWorks.ToList());
        }

        [HttpGet("{Id}")]
        public UserAppointmentsSelectedWorks Get([FromRoute] int Id)
        {
            return (systemDbContext.UserAppointmentsSelectedWorks.Where(c => c.Id == Id).FirstOrDefault());
        }

        [HttpPost]
        public IActionResult Post(UserAppointmentsSelectedWorks userAppointmentsSelectedWorks)
        {
            systemDbContext.UserAppointmentsSelectedWorks.Add(userAppointmentsSelectedWorks);
            systemDbContext.SaveChanges();
            return Accepted();
        }

        [HttpPut]
        public IActionResult Put(UserAppointmentsSelectedWorks userAppointmentsSelectedWorks)
        {
            systemDbContext.UserAppointmentsSelectedWorks.Update(userAppointmentsSelectedWorks);
            systemDbContext.SaveChanges();
            return Accepted();
        }

        [HttpDelete]

        public IActionResult Delete(UserAppointmentsSelectedWorks userAppointmentsSelectedWorks)
        {
            systemDbContext.UserAppointmentsSelectedWorks.Remove(userAppointmentsSelectedWorks);
            systemDbContext.SaveChanges();
            return Accepted();
        }
    }
}
