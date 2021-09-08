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
        private MyDBContext myDbContext;

        public UserAppointmentsSelectedWorksController(MyDBContext context)
        {
            myDbContext = context;
        }

        [HttpGet]
        public IList<UserAppointmentsSelectedWorks> Get()
        {
            return (this.myDbContext.UserAppointmentsSelectedWorks.ToList());
        }
        [HttpPost]
        public IActionResult Post(UserAppointmentsSelectedWorks userAppointmentsSelectedWorks)
        {
            myDbContext.UserAppointmentsSelectedWorks.Add(userAppointmentsSelectedWorks);
            myDbContext.SaveChanges();
            return Accepted();
        }

        [HttpPut]
        public IActionResult Put(UserAppointmentsSelectedWorks userAppointmentsSelectedWorks)
        {
            myDbContext.UserAppointmentsSelectedWorks.Update(userAppointmentsSelectedWorks);
            myDbContext.SaveChanges();
            return Accepted();
        }

        [HttpDelete]

        public IActionResult Delete(UserAppointmentsSelectedWorks userAppointmentsSelectedWorks)
        {
            myDbContext.UserAppointmentsSelectedWorks.Remove(userAppointmentsSelectedWorks);
            myDbContext.SaveChanges();
            return Accepted();
        }
    }
}
