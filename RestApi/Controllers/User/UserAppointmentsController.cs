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
    }
}
