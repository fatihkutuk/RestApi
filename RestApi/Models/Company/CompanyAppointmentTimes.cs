using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestApi.Models.Company
{
    public class CompanyAppointmentTimes
    {
        public int Id { get; set; }
        public int CompanyId { get; set; }
        public DateTime TimeToStart { get; set; }
        public DateTime TimeToFinish { get; set; }
        public bool isAvaible { get; set; }
        public DateTime CreationDateTime { get; set; }
        public DateTime? LastUpdateDateTime { get; set; }
    }
}
