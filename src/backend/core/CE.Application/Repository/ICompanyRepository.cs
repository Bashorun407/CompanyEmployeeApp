using CE.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CE.Application.Repository
{
    public interface ICompanyRepository
    {
        Task<ICollection<Company>> GetAllCompanies(bool trackChanges);
        Task<Company?> GetCompanyById(int id, bool trackChanges);
        void AddCompany(Company company);
        void UpdateCompany(Company company);
        void DeleteCompany(Company company);
    }
}
