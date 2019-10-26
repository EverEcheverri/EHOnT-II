using Employees.Models.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Employees.Repository.Interfaces
{
    public interface IEmployeesRepository
    {
        Task<IEnumerable<EmployeeDto>> GetEmployeesAsync();
    }
}
