using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppWeb.Data_Access.Model;


namespace AppWeb.Data_Access.Model
{
    public class ProfessorBySubject
    {
        public Professor Prof = new();
        public Subject Subject = new();

        public int  IdProfessor { get; set; }
        public int IdSubject { get; set; }


        public void Datos()
        {
            IdProfessor = Prof.IdProfessor;
            IdSubject= Subject.IdSubject;

        }

    }
}
