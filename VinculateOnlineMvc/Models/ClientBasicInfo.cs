using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace VinculateOnlineMvc.Models
{
    public class ClientBasicInfo
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int BasicInfoClientID { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string FirstLastName { get; set; }
        public string SecondLastName { get; set; }
        public DateTime BirthDate { get; set; }
        public string CountryBirthDate { get; set; }
        public string CityBirthDate { get; set; }
        public string Gender { get; set; }
        public string MaritalStatus { get; set; }

    }
}
