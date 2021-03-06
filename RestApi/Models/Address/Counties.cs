using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RestApi.Models.Address
{
    public class Counties
    {
        public int Id { get; set; }
        public string CountyName { get; set; }
        public int CityId { get; set; }
        public DateTime CreationDateTime { get; set; }
        public DateTime? LastUpdateDateTime { get; set; }
        public ICollection<Cties> Cties { get; set; }
    }
}
