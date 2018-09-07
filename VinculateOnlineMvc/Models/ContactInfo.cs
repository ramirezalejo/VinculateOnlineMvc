using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VinculateOnlineMvc.Models
{
    public class ContactInfo
    {
        public string NumberPhone { get; set; }
        public string email { get; set; }
        public string HomePhone { get; set; }
        public string OficcePhone { get; set; }
        public int CountryBirthPlace { get; set; }
        public int ResidenceCountry{ get; set; }
        public int ResidenceCity { get; set; }
        public string Address { get; set; }
        public string NeighBorhood { get; set; }
    }
}
