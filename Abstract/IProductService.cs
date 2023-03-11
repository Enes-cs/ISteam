using ISteam.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISteam.Abstract
{
    public interface IProductService
    {
        void Add(Product product);
        void Remove(Product product);
        void Update(Product product);
    }
}
