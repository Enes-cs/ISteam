using ISteam.Abstract;
using ISteam.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISteam.Concrete
{
    public class ProductManager : IProductService
    {
        public void Add(Product product)
        {
            Console.WriteLine(product.GameName + " Adlı Yeni Ürün Eklendi");
        }

        public void Remove(Product product)
        {
            Console.WriteLine(product.GameName + " Adlı Ürün Silindi");
        }

        public void Update(Product product)
        {
            Console.WriteLine(product.GameName + "Adlı Ürün Güncellendi");
        }
    }
}
