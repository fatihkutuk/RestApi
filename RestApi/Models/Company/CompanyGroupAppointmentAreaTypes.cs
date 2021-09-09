using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestApi.Models.Company
{
    public class CompanyGroupAppointmentAreaTypes
    {
        public int Id { get; set; }
        public int CompanyGroupId { get; set; }
        public int Name { get; set; }
        public int Description { get; set; }
        public DateTime CreationDateTime { get; set; }
        public DateTime? LastUpdateDateTime { get; set; }
    }
}
