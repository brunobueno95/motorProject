using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace motorProject
{
    internal class Car : Vehicle, ICar  
    {
      
        public Car( int horsePower, double price) : base("Car", horsePower, price, 4)
        {
         
                 HorsePower = horsePower;
                 Price = price;
               
        }

        public void testMethod()
        {
           Console.WriteLine("jajja");
        }
    }
}
