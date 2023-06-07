using CE.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CE.Application.Repository
{
    public interface IAddressRepository
    {
        Task<ICollection<Address>> GetAllAddress(bool trackChanges);
        Task<Address> GetAddressById(int id, bool trackChanges);
        void AddAddress(Address address);
        void UpdateAddress(Address address);
        void DeleteAddress(Address address);
    }
}
