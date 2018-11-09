using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace VinculateOnlineMvc.Models
{
    public class IdentityDocument
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IdenDocNumberID { get; set; }
        public string DocNumber { get; set; }

        
        public int DocType { get; set; } = 1;

        public byte[] FileDocNumber { get; set;}
        public DateTime ExpDate { get; set; }
        public string NameCityDocumentExp { get; set; }
    }
}
