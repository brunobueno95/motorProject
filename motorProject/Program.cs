namespace motorProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car vrom = new Car( 10000, 1000000);
            vrom.Description();
            Car sedan = new Car(100, 1000);
            sedan.Description();
            sedan.Upgrade();
            sedan.Description();
            var listOfVehicle = new List<Vehicle>();
            listOfVehicle.Add(sedan);
            listOfVehicle.Add(vrom);
            var Boat = new Boat(3000,8);
            listOfVehicle.Add(Boat);

            Boat.Description();
            var boatFound = listOfVehicle.Find(x => x.Type1 == "boat");
            if (boatFound != null)
            {
                Console.WriteLine(boatFound.HorsePower);
            }
            else { Console.WriteLine("Not found"); }

           
           
            
                foreach (var item in listOfVehicle)
                {
                    Console.WriteLine(item.HorsePower);
                }
               
            
        }
       
    }
}