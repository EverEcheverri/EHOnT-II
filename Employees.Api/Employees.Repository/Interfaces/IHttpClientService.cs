using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Employees.Repository.Interfaces
{
    public interface IHttpClientService
    {
        Task<T> GetAsync<T>(string url);
    }
}
