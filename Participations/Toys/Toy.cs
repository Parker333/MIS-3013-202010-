using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toys
{
    class Toy
    {
        public string Manufacturer { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Notes { get; set; }

        public Toy ()
        {
            Manufacturer = "";
            Name = "";
            Price = 0;
            Notes = "";
        }
        string GetAisle (string toyz)
        {
            return toyz;            
        }
    }
}
