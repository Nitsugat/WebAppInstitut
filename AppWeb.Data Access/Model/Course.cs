using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace AppWeb.Data_Access.Model
{
    public  class Course
    {
        public int IdCourse { get; set; }

        [StringLength(1)]
        public int YearCourse { get; set; }
        public string? Division { get; set; }

    }
}
