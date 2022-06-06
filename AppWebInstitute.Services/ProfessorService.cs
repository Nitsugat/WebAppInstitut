using AppWeb.Data_Access.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppWebInstitute.Services
{
    internal  class ProfessorService : InterfaceProfessorService
    {
        public Task<RequestServices<List<Professor>>> Delete(int IdProfessor)
        {
            throw new NotImplementedException();
        }

        public Task<RequestServices<List<Professor>>> Listar()
        {
            throw new NotImplementedException();
        }

        public Task<RequestServices<List<Professor>>> Save(Professor professor)
        {
            throw new NotImplementedException();
        }

        public Task<RequestServices<Professor>> SearchById(int IdProfessor)
        {
            throw new NotImplementedException();
        }

        public Task<RequestServices<List<Professor>>> Update(Professor professor)
        {
            throw new NotImplementedException();
        }
    }
}
