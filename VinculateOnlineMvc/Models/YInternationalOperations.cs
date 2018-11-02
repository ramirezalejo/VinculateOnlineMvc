using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VinculateOnlineMvc.Models
{
    public class YInternationalOperations
    {

        [Key]
        public string TransactionType { get; set; }
        public string Moneda { get; set; }
        public string CityIntOpe { get; set; }
        public string CountryIntOpe { get; set; }
        public string AccountNumber { get; set; }
    }
}
