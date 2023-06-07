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
    internal sealed class CompanyRepository :RepositoryBase<Company>, ICompanyRepository
    {
        public CompanyRepository(RepositoryContext context):base(context) 
        {
            
        }
        public void AddCompany(Company company)
        {
            Add(company);
        }

        public void DeleteCompany(Company company)
        {
            Delete(company);
        }

        public async Task<ICollection<Company>> GetAllCompanies(bool trackChanges)
        {
           return await FindAllAsync(trackChanges);
        }

        public async Task<Company?> GetCompanyById(int id,bool trackChanges)
        {
            var company = await FindByConditionAsync(company => company.Id.Equals(id), trackChanges);
            return company.FirstOrDefault();
        }

        public void UpdateCompany(Company company)
        {
            Update(company);
        }
    }
}
