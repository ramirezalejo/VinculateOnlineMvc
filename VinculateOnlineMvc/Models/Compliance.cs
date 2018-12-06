using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace VinculateOnlineMvc.Models
{
    public class Compliance
    {
        [Key]
        public int BasicInfoClientID { get; set; }
        
        public int ComplianceID { get; set; }
        /*Conozco y acepto todas las condiciones informadas en la presente solicitud, así como el reglamento de Cuenta de Ahorro.*/
        public Boolean PrivacyAgrement  { get; set; }

        /*●	Declaro que los recursos depositados en la cuenta provienen de mi actividad económica y/o son parte de mi patrimonio. Estos recursos son de origen lícito.*/
        public Boolean LawfulMoney { get; set; }

        /*●	Declaro que los recursos no son administrados a favor de terceras personas.*/
        public Boolean OwnMoney { get; set; }

        /*●	Aceptación de términos y condiciones. */
        public Boolean AcceptAgrement { get; set; }

        /*●	Link con reglamento de Cuenta de Ahorro. */

    }
}
