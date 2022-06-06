using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace AppWeb.Data_Access.Model
{
    public class Resolution
    {
        public int Id { get; set; }

        [StringLength(8,MinimumLength =1,ErrorMessage ="Error, ingresó mas de 8 digitos o no ingreso ninguno.")]
        public string? ResolutionNumber { get; set; }


    }
}
