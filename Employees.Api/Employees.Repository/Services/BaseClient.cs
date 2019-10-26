using Employees.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Employees.Repository.Services
{
    public class BaseClient : IBaseClient
    {
        private readonly string _apiUrl;
        public BaseClient(string apiUrl)
        {
            if (string.IsNullOrWhiteSpace(apiUrl))
            {
                throw new ArgumentNullException(nameof(apiUrl));
            }
            _apiUrl = apiUrl;
        }

        public string GetApiUrl()
        {
            return _apiUrl;
        }
    }
}
