using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AeCAddress.Data;

namespace AeCAddress.Repository
{
    public class AddressRepository : IAddressRepository
    {
        private readonly ApplicationDbContext _applicationDbContext;
        public AddressRepository(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        public AddressModel Add(AddressModel address)
        {
            // save in db
            _applicationDbContext.Endereco.Add(address);
            _applicationDbContext.SaveChanges();

            return address;
        }
    }
}