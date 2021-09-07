using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestApi.Models.User
{
    public class UserAppointmentsSelectedWorks
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int UserAppointmentId { get; set; }
        public int CompanyId { get; set; }
        public int CompanyWorkId { get; set; }
        public DateTime CreationDateTime { get; set; }
        public DateTime? LastUpdateDateTime { get; set; }
    }
}
