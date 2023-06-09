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
    public interface ICompanyService
    {
        Task<CompanyDtoForDisplay> CreateCompany(CompanyDtoForCreation  companyDtoForCreation);
        Task UpdateCompany(CompanyDtoForUpdate companyDtoForUpdate, bool trackChanges);
        Task DeleteCompany(int  companyId);
        Task<IEnumerable<CompanyDtoForDisplay>> GetAllCompanies();
        Task<CompanyDtoForDisplay> GetCompanyById(int companyId);
    }
}
