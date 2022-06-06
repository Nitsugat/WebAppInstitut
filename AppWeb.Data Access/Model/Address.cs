using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace AppWeb.Data_Access.Model
{
    public class Address
    {

        
        public int DomicilioId { get; set; }

        public string? Calle { get; set; }

        [StringLength(8,MinimumLength =1)]
        public int NumeroCalle { get; set; }

        [StringLength(8,MinimumLength =1)]
        public string? Departamento { get; set; }
        public int Piso { get; set; }

        [StringLength(10,MinimumLength =3)]
        public string? Barrio { get; set; }

        [StringLength(12,MinimumLength =6)]
        public string? Manzana { get; set; }

        [StringLength(5,MinimumLength =1)]
        public int Casa { get; set; }

        public DateTime DateUpdate { get; set; }
    }
}
