﻿using Microsoft.AspNetCore.Mvc;
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
    }
}
