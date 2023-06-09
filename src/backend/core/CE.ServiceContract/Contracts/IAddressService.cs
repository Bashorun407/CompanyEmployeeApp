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
    public interface IAddressService
    {

        Task<AddressDtoForDisplay> CreateAddress(AddressDtoForCreation addressDtoForCreation);
        Task UpdateAddress(AddressDtoForUpdate addressDtoForUpdate, bool trackChanges);
        Task<AddressDtoForDisplay> GetAddressById(int id);
    }
}

