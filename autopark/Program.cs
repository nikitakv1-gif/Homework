using System;

namespace autopark
{
    public class Program
    {
        static void Main(string[] args)
        {;
            Car car1 = new Car("Lada", "97", " 2021");
            Car car2 = new Car("Tesla", "751", " 2015");
            Car car3 = new Car("UAZ", "135", " 2018");
            PassengerCar car4 = new PassengerCar("UAZ", "135", " 2018", "4");
            car4.newditails("Двигатель", 1924);
            car4.repairtime("Двигатель");
            car4.repairhistory();
            Truck car5 = new Truck("Lada", "97", " 2021","10000","Иван Федорович");
            car5.ChangeDriverName("Иван Петрович");
            car5.AddCargo("шелк", 5000);
            car5.AddCargo("хлопок", 5000);
            car5.DelCargo("шелк");
            car5.AllCargo();
            List<Car> autos = new List<Car>(){car1,car2,car3,car4,car5};
            Autopark richbitch = new Autopark("richbitch", autos);
            Console.WriteLine(car1.ToString());
            Console.WriteLine(car2.ToString());
            Console.WriteLine(car3.ToString());
            Console.WriteLine(car4.ToString());
            Console.WriteLine(car5.ToString());
            Console.WriteLine(richbitch.ToString());
        }
    }
}

