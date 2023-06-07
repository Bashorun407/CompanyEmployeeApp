using CE.ServiceContract.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CE.ServiceContract.Common
{
    public interface IServiceManager
    {
        public ICompanyService CompanyService { get; }
        public IEmployeeService EmployeeService { get; }
        public IAddressService AddressService { get; }
    }
}
