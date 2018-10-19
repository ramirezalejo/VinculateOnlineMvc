using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace VinculateOnlineMvc.Models
{
    public class EconomicActivity
    {
        [Key]
        /*Fuente de ingresos(Ocupación actual)*/
        public int EconomicActivityType { get; set; }

        /*●	¿Cuánto suman los ingresos mensuales?*/
        public string Income { get; set; }

        /*●	¿Cuánto suman los gastos mensuales?*/
        public string Expense { get; set; }

        /*●	¿Cuánto suman los bienes personales?*/
        public string Assets { get; set; }

        /*●	¿Cuánto es el total de sus deudas?*/
        public string Liabilities { get; set; }

        /*¿Paga impuestos en otros países?*/
        public Boolean PayTaxCountry { get; set; }

        /*●	¿Realiza operaciones o tiene cuentas en moneda extranjera?*/
        public Boolean TransactionsDifCOP { get; set; }

        /*●	¿Cuántos depósitos realizara en el mes?*/
        public int CountDeposit { get; set; }

        /*●	¿Cuál será el monto de los depósitos mensuales?*/
        public int SumDeposit { get; set; }
    }
}
