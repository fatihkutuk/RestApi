using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestApi.Models.User
{
    public class UserAppointments
    {
            
        public int Id { get; set; }
        public int UserId { get; set; }
        public int CompanyAppointmentTimeId { get; set; }
        public bool isFinished { get; set; }
        public bool isConfirmed { get; set; }
        public DateTime CreationDateTime { get; set; }
        public DateTime? LastUpdateDateTime { get; set; }
    }
}
