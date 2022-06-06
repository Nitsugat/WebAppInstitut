using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AppWebInstitute.Services
{
    internal class RequestServices<T>
    {
        public T? Objeto { get; set; }
        public string? Error { get; set; }

        public int Status  { get; set; }

        public bool Successful { get; set; }

        public RequestServices()
        {
            Status = 200;//OK
            Successful = true;
        }
        public void AddBadRequest(string message)
        {
            Status = 404;
            Error= message;
        }
        public void AddInternalServerError(string message)
        {
            Status = 500;
            Error= message;

        }

    }
}
