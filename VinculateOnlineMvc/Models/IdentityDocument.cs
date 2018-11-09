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

        [Range(1,100000000000 ,ErrorMessage = "Numero de documento no valido")]
        public string DocNumber { get; set; }
        public int DocType { get; set; }
        public byte[] FileDocNumber { get; set;}

        [Required(ErrorMessage = "Fecha de expiracion es obligatoria")]
        public DateTime ExpDate { get; set; }

        [Required(ErrorMessage = "El lugar de expediciones obligatorio")]
        public string NameCityDocumentExp { get; set; }
    }
}
