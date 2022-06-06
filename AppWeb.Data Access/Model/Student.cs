using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;




namespace AppWeb.Data_Access.Model
{
    public class Student
    {

        public int IdStudent { get; set; }

        [StringLength(20, MinimumLength = 3, ErrorMessage = "Error, ingresó más o menos caracteres de los disponibles para el nombre ")]
        public string? NameStudent { get; set; }

        [StringLength(20,MinimumLength =3,ErrorMessage ="Error su apellido tiene mas o menos caracteres del permitido, escribalo nuevamente")]
        public string? SurnameStudent { get; set; }

        [StringLength(8,MinimumLength =7)]
        public int Dni { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}")]
        public DateTime DateBird { get; set; }
        public Province? Province { get; set; }
        public Location? Location  { get; set; }
        public Address? AddressStudent { get; set; }
      
        [StringLength(15,MinimumLength =7)]
        public string? NroPhone { get; set; }

        [StringLength(15,MinimumLength =7)]
        public int NroMovilPhone { get; set; }

        [RegularExpression(@"\S+@\S+\.\S+")] 
        public string? Email { get; set; }

        [StringLength(20,MinimumLength=7)]
        public int NumeroLegajo { get; set; }

        public bool Delete { get; set; }

        public DateTime DateUpdate { get; set; }


        public string fullname()
        {

            return SurnameStudent + ", " + NameStudent;
        }

    }
}
