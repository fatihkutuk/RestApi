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
        private systemDbContext systemDbContext;

        public UserAppointmentsSelectedTablesController(systemDbContext context)
        {
            systemDbContext = context;
        }

        [HttpGet]
        public IList<UserAppointmentsSelectedTables> Get()
        {
            return (this.systemDbContext.UserAppointmentsSelectedTables.ToList());
        }

        [HttpGet("{Id}")]
        public UserAppointmentsSelectedTables Get([FromRoute] int Id)
        {
            return (systemDbContext.UserAppointmentsSelectedTables.Where(c => c.Id == Id).FirstOrDefault());
        }

        [HttpPost]
        public IActionResult Post(UserAppointmentsSelectedTables userAppointmentsSelectedTables)
        {
            systemDbContext.UserAppointmentsSelectedTables.Add(userAppointmentsSelectedTables);
            systemDbContext.SaveChanges();
            return Accepted();
        }

        [HttpPut]
        public IActionResult Put(UserAppointmentsSelectedTables userAppointmentsSelectedTables)
        {
            systemDbContext.UserAppointmentsSelectedTables.Update(userAppointmentsSelectedTables);
            systemDbContext.SaveChanges();
            return Accepted();
        }

        [HttpDelete]

        public IActionResult Delete(UserAppointmentsSelectedTables userAppointmentsSelectedTables)
        {
            systemDbContext.UserAppointmentsSelectedTables.Remove(userAppointmentsSelectedTables);
            systemDbContext.SaveChanges();
            return Accepted();
        }
    }
}
