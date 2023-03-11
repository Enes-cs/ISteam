using ISteam.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISteam.Entities
{
    public class Product:IEntitiy
    {
        public string GameName { get; set; }
        public int Price { get; set; }
    }
}
