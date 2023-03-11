using ISteam.Abstract;
using ISteam.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISteam.Concrete
{
    public class OfferManager : IOfferService
    {
        public void Add(Offer offer)
        {
            Console.WriteLine(offer.Name + " Adlı Yeni Kampanya Eklendi");
        }

        public void Remove(Offer offer)
        {
            Console.WriteLine(offer.Name + " Kampanyası Silindi");
        }

        public void Update(Offer offer)
        {
            Console.WriteLine(offer.Name + " Kampanyası Güncellendi");
        }
    }
}
