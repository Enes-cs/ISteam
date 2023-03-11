using ISteam.Adapters;
using ISteam.Concrete;
using ISteam.Entities;

namespace ISteam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer(new MernisServiceAdapter());
            customer.Name = "İbrahim Enes";
            customer.LastName = "ÖZBAY";
            customer.BirthYear = new DateTime(1995, 11, 14);
            customer.TcNo = 62791010354;

            Customer customer1 = new Customer(new MernisServiceAdapter());
            customer1.Name = "Enes";
            customer1.LastName = "DELİBAŞ";
            customer1.BirthYear = new DateTime(1997, 11, 14);
            customer1.TcNo = 62791010357;


            CustomerManager customerManager = new CustomerManager(new MernisServiceAdapter());

            customerManager.Save(customer);
            customerManager.Save(customer1);

            Product product = new Product();
            product.GameName = "ARFF Online";
            product.Price = 2222;

            ProductManager productManager = new ProductManager();
            productManager.Add(product);

            Offer offer = new Offer();
            offer.Name = "Kütahyalı İndirimi %43 ";
            offer.Rate= 43;
            
            OfferManager offerManager = new OfferManager();
            offerManager.Add(offer);

            SalesManager salesManager = new SalesManager();
            salesManager.Sell(product,customer1,offer);
            salesManager.Sell(product,customer,offer);

        }
    }
}