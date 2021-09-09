using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RestApi.Models.Address
{
    public class Cties
    {
        public int Id { get; set; }
        public string CityName { get; set; }
        public DateTime CreationDateTime { get; set; }
        public DateTime? LastUpdateDateTime { get; set; }
        public ICollection<Counties> Counties { get; set; }
    }
}
