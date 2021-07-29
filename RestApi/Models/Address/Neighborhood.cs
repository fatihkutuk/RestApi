using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestApi.Models
{
    public class Neighborhood
    {
        public int Id { get; set; }
        public string NeighborhoodName { get; set; }
        public int CountyId { get; set; }

        public DateTime CreationDateTime { get; set; }
        public DateTime? LastUpdateDateTime { get; set; }
    }
}
