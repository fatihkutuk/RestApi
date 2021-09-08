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
        private MyDBContext myDbContext;

        public UserAppointmentsController(MyDBContext context)
        {
            myDbContext = context;
        }

        [HttpGet]
        public IList<UserAppointments> Get()
        {
            return (this.myDbContext.UserAppointments.ToList());
        }
        [HttpPost]
        public IActionResult Post(UserAppointments userAppointments)
        {
            myDbContext.UserAppointments.Add(userAppointments);
            myDbContext.SaveChanges();
            return Accepted();
        }

        [HttpPut]
        public IActionResult Put(UserAppointments userAppointments)
        {
            myDbContext.UserAppointments.Update(userAppointments);
            myDbContext.SaveChanges();
            return Accepted();
        }

        [HttpDelete]

        public IActionResult Delete(UserAppointments userAppointments)
        {
            myDbContext.UserAppointments.Remove(userAppointments);
            myDbContext.SaveChanges();
            return Accepted();
        }
    }
}
