using AppWeb.Data_Access.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppWebInstitute.Services
{
    internal class AlumnoServices : InterfaceAlumnoServices
    {
        public Task<RequestServices<List<Student>>> Actualizar(Student alumno)
        {
            throw new NotImplementedException();
        }

        public Task<RequestServices<Student>> BuscarPorId(int id)
        {
            throw new NotImplementedException();
        }

        public Task<RequestServices<List<Student>>> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<RequestServices<List<Student>>> Guardar(Student alumno)
        {
            throw new NotImplementedException();
        }

        public Task<RequestServices<List<Student>>> Listar()
        {
            throw new NotImplementedException();
        }

        public Task<RequestServices<List<Student>>> Save(Student alumno)
        {
            throw new NotImplementedException();
        }

        public Task<RequestServices<Student>> SearchById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<RequestServices<List<Student>>> Update(Student alumno)
        {
            throw new NotImplementedException();
        }
    }
}
