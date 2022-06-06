using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace AppWeb.Data_Access.Model
{
    public class Cursado
    {
        public int IdCursado { get; set; }

        [StringLength(10,MinimumLength =2)]
        public string? TipoCursado { get; set; }
    }
}
