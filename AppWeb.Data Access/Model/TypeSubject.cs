using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace AppWeb.Data_Access.Model
{
    public class TypeSubject
    {
        public int IdTypeSubject { get; set; }

        [StringLength(10,MinimumLength =2)]
        public string? Type { get; set; }
    }
}
