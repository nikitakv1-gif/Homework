using System;

namespace HM
{
    class Solution
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Номер 2.1");
            int bi = Convert.ToInt32(Console.ReadLine());
            // string b = Convert.ToString(bi,2); способ из интернета, не уверерен, что можно им пользоваться, хотя запрета вроде нет
            // Console.WriteLine(b);
            string k = "";
            while (bi!=0)
            {
                string b = Convert.ToString(bi%2);//преобразовываю остаток от деления на два
                k = (bi%2) + k;//записываю таким образом, что бы потом не пришлось переворачивать число
                bi >>= 1;// получаю новое число
            }
            Console.WriteLine(k);
        }
    }
}
