using DotNet7.Models;

namespace DotNet7.Services
{
    public interface IPhoneService
    {
        List<Phone> GetAllPhones();
        Phone GetSinglePhone(int id);
        List<Phone> AddPhone(Phone phone);
        List<Phone> UpdatePhone(int id,Phone request);
        List<Phone> DeletePhone(int id);
    }
}
