
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppWeb.Data_Access.Model;

namespace AppWebInstitute.Services

{
    internal interface InterfaceAlumnoServices
    {
        Task<RequestServices<List<Student>>>Listar();
        Task<RequestServices<Student>>SearchById(int id);
        Task<RequestServices<List<Student>>> Save(Student alumno);
        Task<RequestServices<List<Student>>> Update(Student alumno);
        Task<RequestServices<List<Student>>> Delete(int id);
        

    }
}
