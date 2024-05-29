namespace AeCAddress.Repository
{
    public interface IAddressRepository
    {
        List<AddressModel> ListAll();
        AddressModel Add(AddressModel address);
        AddressModel FindOne(int id);
        AddressModel Update(AddressModel address);
        bool Delete(int id);
    }
}