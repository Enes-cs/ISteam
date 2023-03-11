using ISteam.Abstract;
using ISteam.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISteam.Concrete
{
    public class SalesManager : ISalesService
    {
        public void Sell(Product product, Customer customer, Offer offer)
        {
            float price = ((float)(product.Price * (100 + (-offer.Rate)) / 100));
            Console.WriteLine(customer.Name + " Adlı Kullanıcı " + product.GameName + " Adlı Oyunu " + offer.Name + " Adlı Kampanya ile " +product.Price+" Tl yerine "+price + " Tl'ye Satın Aldı");
        }
    }
}
