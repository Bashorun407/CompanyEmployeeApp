using CE.Application.DTOs.DtoForCreation;
using CE.Application.DTOs.DtoForDisplay;
using CE.Application.DTOs.DtoForUpdate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CE.ServiceContract.Contracts
{
    public interface IEmployeeService
    {
        Task<EmployeeDtoForDisplay> CreateEmployee(EmployeeDtoForCreation employeeDtoForCreation);
        Task UpdateEmployee(EmployeeDtoForUpdate employeeDtoForUpdate, bool trackChanges);
        Task<IEnumerable<EmployeeDtoForDisplay>> GetAllCompanyEmployees(int companyId);
        Task<EmployeeDtoForDisplay> GetCompanyEmployeeById(int companyId, int employeeId);
        Task DeleteEmployee(int companyId, int employeeId);
    }
}
