using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestApi.Models.Company
{
    public class CompanyImages
    {
        public int Id { get; set; }
        public int CompanyId { get; set; }
        public string ImagePath { get; set; }
        public string ImageDescription { get; set; }
        public DateTime CreationDateTime { get; set; }
        public DateTime? LastUpdateDateTime { get; set; }
    }
}
