using CE.Application.Common;
using CE.Application.Repository;
using CE.Persistence.Context;
using CE.Persistence.Repositories.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CE.Persistence.Repositories.Common
{
    public class RepositoryManager : IRepositoryManager
    {
        private readonly Lazy<ICompanyRepository> _companyRepository;
        private readonly Lazy<IAddressRepository> _addressRepository;
        private readonly Lazy<IEmployeeRepository> _employeeRepository;
        private readonly RepositoryContext _repositoryContext;

        public RepositoryManager(RepositoryContext context)
        {
            _companyRepository = new Lazy<ICompanyRepository>(() => new CompanyRepository(context));
            _addressRepository = new Lazy<IAddressRepository> (()=>new AddressRepository(context));
            _employeeRepository = new Lazy<IEmployeeRepository>(()=>new EmployeeRepository(context));
            _repositoryContext = context;
        }

        public ICompanyRepository CompanyRepository => _companyRepository.Value;

        public IEmployeeRepository EmployeeRepository => _employeeRepository.Value;

        public IAddressRepository AddressRepository => _addressRepository.Value;

        public async Task SaveAsync() => await _repositoryContext.SaveChangesAsync();
    }
}
