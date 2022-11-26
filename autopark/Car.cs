using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace autopark
{
    public class Car
    {
        protected string _name;
        protected string _power;
        protected string _yearofcreation;
        public string Name { get => _name; set => _name = value;}
        public string Power { get => _power; set => _power = value; }
        public string Yearofcreation { get => _yearofcreation; set => _yearofcreation = value;}
        public Car(string name, string power, string yearofcreation)
        {
            _name = name;
            _power = power;
            _yearofcreation = yearofcreation;

            Console.WriteLine("Новая машина создана");
        }
        public override string ToString()
        {
            return $"марка : {_name},мощность : {_power}, год создания : {_yearofcreation}";
        }
    }
}
