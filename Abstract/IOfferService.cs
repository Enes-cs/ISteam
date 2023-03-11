using ISteam.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISteam.Abstract
{
    public interface IOfferService
    {
        void Add(Offer offer);
        void Remove(Offer offer);
        void Update(Offer offer);
    }
}
