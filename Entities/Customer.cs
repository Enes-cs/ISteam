using ISteam.Abstract;
using ISteam.Adapters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISteam.Entities
{
    public class Customer:IEntitiy
    {
        

        public Customer(MernisServiceAdapter mernisServiceAdapter)
        {
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public DateTime BirthYear { get; set; }
        public long TcNo { get; set; }
    }
}
