using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace VinculateOnlineMvc.Models
{
    public class IdentityDocument
    {
        [Key]
        
        
        public int IdenDocNumberID { get; set; }

        [Range(1,10 ,ErrorMessage = "Title is required")]
        public string DocNumber { get; set; }

        public int DocType { get; set; }

        public byte[] FileDocNumber { get; set;}

        [Required(ErrorMessage = "Title is required")]
        public DateTime ExpDate { get; set; }

        [Required(ErrorMessage = "Title is required")]
        public string NameCityDocumentExp { get; set; }
    }
}
