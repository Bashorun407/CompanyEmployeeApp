using CE.Application.Repository;
using CE.Domain.Models;
using CE.Persistence.Context;
using CE.Persistence.Repositories.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CE.Persistence.Repositories.Repo
{
    internal sealed class EmployeeRepository : RepositoryBase<Employee>, IEmployeeRepository
    {
        public EmployeeRepository(RepositoryContext context):base(context)
        {
            
        }
        public void AddEmployee(Employee employee)
        {
            Add(employee);
        }

        public void DeleteEmployee(Employee employee)
        {
            Delete(employee);
        }

        public async Task<ICollection<Employee>> GetAllEmployees(bool trackChanges)
        {
            return await FindAllAsync(trackChanges);
        }

        public async Task<Employee?> GetEmployeeById(int id, bool trackChanges)
        {
            var employee = await FindByConditionAsync(employee=>employee.Id.Equals(id),trackChanges);
            return employee.FirstOrDefault();
        }

        public void UpdateEmployee(Employee employee)
        {
            Update(employee);   
        }
    }
}
