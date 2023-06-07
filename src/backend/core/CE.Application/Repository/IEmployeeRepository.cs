using CE.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CE.Application.Repository
{
    public interface IEmployeeRepository
    {
        Task<ICollection<Employee>> GetAllEmployees(bool trackChanges);
        Task<Employee> GetEmployeeById(int id, bool trackChanges);
        void AddEmployee(Employee employee);
        void UpdateEmployee(Employee employee);
        void DeleteEmployee(Employee employee);
    }
}
