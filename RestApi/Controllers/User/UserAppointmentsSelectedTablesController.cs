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
    public class UserAppointmentsSelectedTablesController : Controller
    {
        private MyDBContext myDbContext;

        public UserAppointmentsSelectedTablesController(MyDBContext context)
        {
            myDbContext = context;
        }

        [HttpGet]
        public IList<UserAppointmentsSelectedTables> Get()
        {
            return (this.myDbContext.UserAppointmentsSelectedTables.ToList());
        }
    }
}
