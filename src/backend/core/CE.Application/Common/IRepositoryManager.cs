using CE.Application.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CE.Application.Common
{
    public interface IRepositoryManager
    {
        public ICompanyRepository CompanyRepository { get; }
        public IEmployeeRepository EmployeeRepository { get; }
        public IAddressRepository AddressRepository { get; }
        Task SaveAsync();
    }
}
