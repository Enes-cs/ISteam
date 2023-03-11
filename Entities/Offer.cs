using ISteam.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISteam.Entities
{
    public class Offer :IEntitiy
    {
        public string Name { get; set; }
        public float Rate { get; set; }

    }
}
