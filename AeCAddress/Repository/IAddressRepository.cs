namespace AeCAddress.Repository
{
    public interface IAddressRepository
    {
        List<AddressModel> ListAll();
        AddressModel Add(AddressModel address);
    }
}