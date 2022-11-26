using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace autopark
{
    public class Truck : Car
    {
        protected string _weight;
        protected string _drivername;
        protected Dictionary<string,int> _cargo;
        public string Drivername {get =>_drivername; set  => _drivername = value;}
        public Truck (string name, string power, string yearofcreation, string weight, string drivername)
        :base(name,power,yearofcreation)
        {
            this._weight = weight;
            this._drivername = drivername;
            this._cargo = new Dictionary<string, int>();
        }
        public string ChangeDriverName(string name)//смена имени водителя
        {
            _drivername = name;
            return _drivername;
        }
        public void AddCargo(string name, int cargoweight)//добавление груза
        {
            _cargo.Add(name, cargoweight);
        }
        public void DelCargo(string name)//удаление груза
        {
            _cargo.Remove(name);
        }
        public string AllCargo()//вывод всех грузов
        {
            if (_cargo.Count >0 )
            {
                foreach (string i in _cargo.Keys)
                {
                    string forread = $"{i} : {_cargo[i]}";
                    Console.WriteLine(forread);
                }
                return "";
            }
            else
            {
                return "Машина полностью пустая";
            }
            throw new Exception("Вот сейчас очень неожиданно было");
        }
        public override string ToString()
        {
            return $"марка : {_name},мощность : {_power}, год создания : {_yearofcreation}, грузоподъемность : {_weight}, ФИ водителя : {_drivername}";
        }
    }
}
