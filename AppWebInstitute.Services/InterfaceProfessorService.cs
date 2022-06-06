using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppWeb.Data_Access.Model;

namespace AppWebInstitute.Services
{
    internal interface InterfaceProfessorService
    {
        Task<RequestServices<List<Professor>>> Listar();
        Task<RequestServices<Professor>> SearchById(int IdProfessor);
        Task<RequestServices<List<Professor>>> Save(Professor professor);
        Task<RequestServices<List<Professor>>> Update(Professor professor);
        Task<RequestServices<List<Professor>>> Delete(int IdProfessor);
    }
}
