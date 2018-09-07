using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VinculateOnlineMvc.Models
{
    public class DataInfo
    {
        [Key]
        public int ClientID { get; set; }
        public IdentityDocument IdentityDocument { get; set; }
        public ClientBasicInfo ClientBasicInfo { get; set; }
    }
}
