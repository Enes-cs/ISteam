using ISteam.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISteam.Abstract
{
    public interface ISalesService
    {
        void Sell(Product product,Customer customer,Offer offer);
    }
}
