using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace motorProject
{
    internal class Boat : Vehicle
    {
        public Boat(int horsePower, double price) : base("boat", horsePower, price, 4)
        {
        }
    }
}
