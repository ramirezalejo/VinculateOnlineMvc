using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace VinculateOnlineMvc.Models
{
    public class IdentityDocument
    {
        public string DocNumber { get; set; }
        public int DocType { get; set; }
        public byte[] FileDocNumber { get; set;}
        public DateTime ExpDate { get; set; }
        public string NameCityDocumentExp{ get; set; }
    }
}
