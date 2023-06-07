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
    internal sealed class AddressRepository : RepositoryBase<Address>, IAddressRepository
    {
        public AddressRepository(RepositoryContext context):base(context)
        {
            
        }
        public void AddAddress(Address address)
        {
            Add(address);
        }

        public void DeleteAddress(Address address)
        {
            Delete(address);
        }

        public async Task<Address?> GetAddressById(int id, bool trackChanges)
        {
            var address = await FindByConditionAsync(address=>address.Id.Equals(id), trackChanges);
            return address.FirstOrDefault();
        }

        public async Task<ICollection<Address>> GetAllAddress(bool trackChanges)
        {
            return await FindAllAsync(trackChanges);
        }

        public void UpdateAddress(Address address)
        {
            Update(address);    
        }
    }
}
