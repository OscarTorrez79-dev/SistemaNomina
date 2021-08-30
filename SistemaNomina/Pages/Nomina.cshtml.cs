using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace SistemaNomina.Pages
{
    public class NominaModel : PageModel
    {

      public  string Nombre { get; set; }
       public string Apellido { get; set; }
       public string Cargo { get; set; }
        public double SalarioMensual { get; set; }
        public double AFP { get; set; }
        public double DescuentoARS { get; set; }
        public double Descuento { get; set; }
        public double TotalDeDescuentos { get; set; }
        public double SalarioNeto { get; set; }

        public void OnGet()
        {
        }
    }
}
