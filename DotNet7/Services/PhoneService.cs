using DotNet7.Models;

namespace DotNet7.Services
{
    public class PhoneService : IPhoneService
    {
        private static List<Phone> phones = new List<Phone>()
        {
            new Phone
            {
                Id= 1,
                Name="Samsung s8",
                Manufacturer="Samsung",
                Resolution=8,
                Cpu="Qualcomm"
            }
        };
        public List<Phone> AddPhone(Phone phone)
        {
            phones.Add(phone);
            return phones;
        }

        public List<Phone> DeletePhone(int id)
        {
            var phone =phones.Find(x => x.Id == id);
            if (phone is null)
                return null;
            phones.Remove(phone);
            return phones;

        }

        public List<Phone> GetAllPhones()
        {
            return phones;
        }

        public Phone? GetSinglePhone(int id)
        {
            var phone=phones.Find(x=>x.Id == id);
            if(phone is null) return null;
            return phone;
        }

        public List<Phone>? UpdatePhone(int id, Phone request)
        {
            var phone = phones.Find(x => x.Id == id);
            if (phone is null)
                return null;
            phone.Name= request.Name;
            phone.Cpu= request.Cpu;
            phone.Resolution= request.Resolution;
            phone.Manufacturer= request.Manufacturer;
            return phones;
        }

       
    }
}
