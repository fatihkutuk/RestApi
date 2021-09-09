using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestApi.Models.Company
{
    public class Companies
    {
        public int Id { get; set; }
        public string CompanyName { get; set; }
        public int CompanyGroupId { get; set; }
        public int CompanyAdressCityId { get; set; }
        public int CompanyAdressCountyId { get; set; }
        public int CompanyAdressNeighborhoodId { get; set; }
        public int CompanyAdressStreetId { get; set; }
        public string CompanyAddress { get; set; }
        public string CompanyLocation { get; set; }
        public string CompanyDelegateName { get; set; }
        public string Password { get; set; }
        public string CompanyDelegatePhoneNumber { get; set; }
        public string CompanyMail { get; set; }
        public DateTime CreationDateTime { get; set; }
        public DateTime? LastUpdateDateTime { get; set; }
    }
}
