using ISteam.Abstract;
using ISteam.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISteam.Concrete
{
    public class CustomerManager : ICustomerService
    {
        ICustomerCheckService _customerCheckService;

        public CustomerManager(ICustomerCheckService customerCheckService)
        {
            _customerCheckService = customerCheckService;
        }

        public void Save(Customer customer)
        {
            if (_customerCheckService.CheckIfRealPerson(customer))
            {

                Console.WriteLine(customer.Name + " Kimlik Doğrulaması Başarı İle Yapıldı ve Kaydedildi.");
            }
            else
            {
                Console.WriteLine(customer.Name + " Adlı kişinin Kimlik bilgileri doğrulanamdı...");
            }

        }


        public void Delete(Customer customer)
        {
            Console.WriteLine(customer.Name + " Adlı Kullanıcı Silindi");
        }


        public void Update(Customer customer)
        {
            Console.WriteLine(customer.Name + " Adlı Kullanıcı Güncellendi");
        }


    }
}
