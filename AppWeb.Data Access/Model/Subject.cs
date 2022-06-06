using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace AppWeb.Data_Access.Model
{
    public class Subject
    {
        public Course cour = new();
        public TypeSubject subjectType = new();
        public Cursado cursado = new();
        public Resolution resolution = new();

        public int IdSubject { get; set; }

        [StringLength(12,MinimumLength =2)]
        public string? NameSubject { get; set; }
        public int Course { get; set; }
        public int TypeSubject { get; set; }
        public int Cursado { get; set; }
        public int Resolution { get; set; }


        public void Datos() {

            TypeSubject = subjectType.IdTypeSubject;
            Cursado = cour.IdCourse;
            Cursado = cursado.IdCursado;
            Resolution = resolution.Id;
        }
         
    }

}
















