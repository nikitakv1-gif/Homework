using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace autopark
{
    public class PassengerCar : Car
    {
        private string _numberofpassangers;
        private Dictionary<string, int> _rembook;
        public string Numberofpassangers { get => _numberofpassangers; set => _numberofpassangers = value;}

        public PassengerCar (string name, string power, string yearofcreation, string numberofpassengers):base(name,power,yearofcreation)
        {
            this._numberofpassangers = numberofpassengers;
            this._rembook = new Dictionary<string, int>();
        }
        public void newditails(string nameofdt, int year)//добавление записи в ремонтнуб книжку
        {
            bool inornot = _rembook.ContainsKey(nameofdt);
            if (inornot == false)
                _rembook.Add(nameofdt, year);
            else
                _rembook[nameofdt] = year;
        }
        public string repairtime(string nameofdt)//время ремонта по названию детали
        {
            bool inornot = _rembook.ContainsKey(nameofdt);
            if (inornot == false)
            {
                Console.WriteLine("Эту деталь еще не ремонтировали"); /*return с такой же строкой что и в WriteLine
                 не работает, а без return выдается ошибка, не все пути выводят значение как исправить не понял*/
                return "";
            }
            else
            {
                Console.WriteLine($"{nameofdt} ремонтировали в послений раз в {_rembook[nameofdt]} году");
                return"";
            }
        }
        public string repairhistory() // вывод всей ремонтной книжки
        {
            if (_rembook.Count >0 )
            {
                foreach (string i in _rembook.Keys)
                {
                    string forread = $"{i} : {_rembook[i]}";
                    Console.WriteLine(forread);
                }
                return "";
            }
            else
            {
                return "Машину еще не ремонтировали";
            }
            throw new Exception("Вот сейчас очень неожиданно было");//говорил что не все пути заканчиваются вывдомо, смог исправить только так
        }
        public override string ToString()
        {
            return $"марка : {_name},мощность : {_power}, год создания : {_yearofcreation}, кол-во мест : {_numberofpassangers}";
        }
    }
}
