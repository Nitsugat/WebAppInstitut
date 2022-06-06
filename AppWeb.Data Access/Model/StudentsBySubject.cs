using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppWeb.Data_Access.Model
{
    public class StudentsBySubject
    {
        public Student Student = new();
        public Subject Subject = new();

        public int IdStudent { get; set; }
        public int IdSubject { get; set; }

        public void Datos()
        {
            IdStudent = Student.IdStudent;
            IdSubject = Subject.IdSubject;
        }


    }
}
