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

        public List<AddressModel> ListAll()
        {
            return [.. _applicationDbContext.Endereco]; // retorna uma lista ;
        }

        public AddressModel Add(AddressModel address)
        {
            // save in db
            _applicationDbContext.Endereco.Add(address);
            _applicationDbContext.SaveChanges();

            return address;
        }

        public AddressModel FindOne(int id)
        {
            return _applicationDbContext.Endereco.FirstOrDefault(item => item.Id == id);
        }

        public AddressModel Update(AddressModel address)
        {
            AddressModel addressDB = FindOne(address.Id) ?? throw new Exception("There was an error updating the contact!");

            addressDB.CEP = address.CEP;
            addressDB.Logradouro = address.Logradouro;
            addressDB.Complement = address.Complement;
            addressDB.Bairro = address.Bairro;
            addressDB.Cidade = address.Cidade;
            addressDB.Numero = address.Numero;
            addressDB.UF = address.UF;

            _applicationDbContext.Endereco.Update(addressDB);
            _applicationDbContext.SaveChanges();

            return addressDB;
        }

        public bool Delete(int id)
        {
            AddressModel addressDB = FindOne(id) ?? throw new Exception("There was an error deleting the address.");

            _applicationDbContext.Endereco.Remove(addressDB);
            _applicationDbContext.SaveChanges();

            return true;
        }
    }
}