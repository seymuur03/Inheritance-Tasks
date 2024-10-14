using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASKS
{
    internal class Product
    {
        public string Name;
        public int Price ;
        public Product(string name,int price = 10)
        {
            Name=name;
            Price = price;
        }
    }
}
