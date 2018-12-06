using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace VinculateOnlineMvc.Models
{
    public class ContactInfo
    {
        [Key]
        public int BasicInfoClientID { get; set; }
        public Int64 NumberPhone { get; set; }
        public string email { get; set; }
        public int HomePhone { get; set; }
        public int OficcePhone { get; set; }
        public string CountryBirthPlace { get; set; }
        public string ResidenceCountry { get; set; }
        public string ResidenceCity { get; set; }
        public string Address { get; set; }
        public string NeighBorhood { get; set; }
    }
}
