using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VinculateOnlineMvc.Models
{
    public class CompanyInformation
    {
        /*Nombre de la empresa donde trabaja(si es empleado obligatorio)*/
        public String NameCompany { get; set; }

        //Actividad económica de la empresa(si es empleado obligatorio)
        public String ActivityTypeCompany { get; set; }

        //●	Cargo que desempeña(si es empleado obligatorio)
        public String NamePosition { get; set; }

        //●	Ciudad donde está ubicada la empresa(si es empleado obligatorio)
        public String CityCompany { get; set; }

        //●	Teléfono fijo de la empresa(si es empleado obligatorio)
        public String PhoneCompany { get; set; }

    }
}
