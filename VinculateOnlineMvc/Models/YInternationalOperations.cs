using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace VinculateOnlineMvc.Models
{
    public class YInternationalOperations
    {
        [Key]
        public int BasicInfoClientID { get; set; }
        public int YInternationalOperationsID { get; set; }
        public string TransactionType { get; set; }
        public string Moneda { get; set; }
        public string CityIntOpe { get; set; }
        public string CountryIntOpe { get; set; }
        public string AccountNumber { get; set; }
    }
}
