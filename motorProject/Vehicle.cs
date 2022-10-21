using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace motorProject
{
    abstract internal class Vehicle
    {
        public string Type1 { get;  set; }
        public int HorsePower { get; set; }
        public double Price { get; set; }

        public int PersonsFit { get; set; }


        public Vehicle(string type, int horsePower, double price, int personsFit)
        {
            Type1 = type;
            HorsePower = horsePower;
            Price = price;
            PersonsFit = personsFit;

        }

      


        public void Description()
        {
            Console.WriteLine($"This vehicle is a {Type1} it has {HorsePower} horse-power, the price is {Price}, and it fits {PersonsFit} persons inside");
        }

        public void Upgrade()
        {
            HorsePower += 1000;
            Price += 1000;
            PersonsFit += 2;

        }

    }
}
