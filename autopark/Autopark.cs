using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace autopark
{
    public class Autopark
    {
        private string _nameofautopark;
        public List<Car> _autopark;
        public Autopark(string nameofautopark, List<Car> cars)
        {
            _nameofautopark = nameofautopark;
            _autopark = cars;
        }
        public override string ToString()
        {
            foreach (Car car in _autopark)
            {
                Console.WriteLine(car.ToString() + '\n');
            }
            return "";
        }


    }
}
