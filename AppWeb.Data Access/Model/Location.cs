using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace AppWeb.Data_Access.Model
{
    public class Location
    {
        public int IdLocation { get; set; }

        [StringLength(20,MinimumLength =4)]
        public string? NameLocation { get; set; }

        [StringLength (10,MinimumLength =3)]
        public string? CodePostal { get; set; }

        public int ProvinceID { get; set; }

        public DateTime DateUpdate { get; set; }
    }
}
