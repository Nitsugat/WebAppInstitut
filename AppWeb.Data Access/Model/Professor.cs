using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppWeb.Data_Access.Model
{
    public class Professor
    {

        public int IdProfessor { get; set; }

        [StringLength(20, MinimumLength = 3, ErrorMessage = "Error, ingresó más o menos caracteres de los disponibles para el nombre ")]
        public string? NameProfessor { get; set; }

        [StringLength(20, MinimumLength = 3, ErrorMessage = "Error,ingresó más caracteres o menos de los disponibles para el apellido ")]
        public string? SurnameProfessor { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}")]
        public Address? AddressProfessor { get; set; }

        [StringLength(8, MinimumLength = 7)]
        public int  DniProfessor { get; set; }

        public Province Province { get; set; }
        public Location Location { get; set; }

        [StringLength(maximumLength: 20, MinimumLength = 7)]
        public int NumeroLegajo { get; set; }

        [RegularExpression(@"\S+@\S+\.\S+")]
        public string? Email { get; set; }

        [StringLength(15, MinimumLength = 7)]
        public int NroMovilPhone { get; set; }

        [StringLength(15, MinimumLength = 7)]
        public string? NroPhone { get; set; }

        public bool Delete { get; set; }

        public DateTime DateUpdate { get; set; }

        public string fullname()
        {

            return SurnameProfessor + ", " + NameProfessor;
        }





    }
}
