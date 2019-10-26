using Employees.Business.Tests.Stubs;
using Employees.Repository.Interfaces;
using Moq;
using System;
using System.Collections.Generic;
using System.Text;

namespace Employees.Business.Tests.MockRepository
{
    public class EmployeesRepositoryMock
    {
        public Mock<IEmployeesRepository> EmployeesRepository { get; set; }
        public EmployeesRepositoryMock()
        {
            EmployeesRepository = new Mock<IEmployeesRepository>();
            Setup();
        }

        private void Setup()
        {
            EmployeesRepository.Setup(x => x.GetEmployeesAsync()).ReturnsAsync(EmployeesStub.EmployeesList);
        }
    }
}
