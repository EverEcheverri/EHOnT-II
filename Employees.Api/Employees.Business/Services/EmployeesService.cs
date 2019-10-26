using Employees.Business.Interfaces;
using Employees.Models.Dto;
using Employees.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees.Business.Services
{
    public class EmployeesService : IEmployeesService
    {
        private readonly IEmployeesRepository _employeesRepository;
        public EmployeesService(IEmployeesRepository employeesRepository)
        {
            _employeesRepository = employeesRepository ?? throw new ArgumentNullException(nameof(employeesRepository));
        }
        public async Task<IEnumerable<EmployeeDto>> GetEmployeeByIdAsync(int id)
        {
            var result = await _employeesRepository.GetEmployeesAsync();
            return result.ToList().Where(x => x.Id == id);
        }

        public async Task<IEnumerable<EmployeeDto>> GetEmployeesAsync()
        {
            return await _employeesRepository.GetEmployeesAsync();
        }
    }
}
