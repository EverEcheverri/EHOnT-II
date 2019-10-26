using Employees.Models.Dto;
using Employees.Repository.Interfaces;
using Employees.Repository.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Employees.Repository.ResourceAccess
{
    public class EmployeesResource : IEmployeesRepository
    {
        private readonly IHttpClientService _httpClientService;
        private readonly IBaseClient _baseClient;
        public EmployeesResource(IHttpClientService httpClientService, IBaseClient baseClient)
        {
            _httpClientService = httpClientService ?? throw new ArgumentNullException(nameof(httpClientService));
            _baseClient = baseClient ?? throw new ArgumentNullException(nameof(baseClient));
        }

        public async Task<IEnumerable<EmployeeDto>> GetEmployeesAsync()
        {
            return await _httpClientService.GetAsync<IEnumerable<EmployeeDto>>(_baseClient.GetApiUrl());
        }
    }
}
