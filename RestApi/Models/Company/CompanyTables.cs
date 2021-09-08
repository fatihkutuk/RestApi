using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestApi.Models.Company
{
    public class CompanyTables
    {
        public int Id { get; set; }
        public int CompanyId { get; set; }
        public int Name { get; set; }
        public int isAvailable { get; set; }
        public DateTime CreationDateTime { get; set; }
        public DateTime? LastUpdateDateTime { get; set; }
    }
}
