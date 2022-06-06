using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace AppWeb.Data_Access.Model
{
    public class Province
    {
        public int idProvincia { get; set; }

        [StringLength(maximumLength:15 , MinimumLength =3)]
        public string? NombreProvincia { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}")]
        public DateTime DateUpdate { get; set; }
    }
}
