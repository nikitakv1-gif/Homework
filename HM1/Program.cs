using System;

namespace HM
{
    class Program
    {
        static void Solut(string[] args)
        {
            Console.WriteLine("Номер 1.1");
            for (int i = 0; i <= 6; i++)//последнее число
            {
                for (int r = i+1; r<=7; r++ )//предпоследнее число
                {
                    for (int t = r + 1; t<=8; t++ )//второе число
                    {
                        for (int y = t + 1; y <=9; y++)//первое число
                        {
                            string nm = $"{y}{t}{r}{i}";
                            Console.WriteLine(nm);
                        }
                    }
                }
            }
            Console.WriteLine("Номер 1.2");
            Console.WriteLine("Введи число");
            int num = Convert.ToInt16(Console.ReadLine());//получаю число
            int mnum = 0;//переменная для начальной строки
            int numc = 0;
            int n = num;//сохранение длянны числа в отдельную переменную, которая не будет меняться
            while (num!=0)// цикл определения первоночального числа
            {
                mnum += (num) *(int)Math.Pow(10,--num);
                numc += 1 *(int)Math.Pow(10,num);
            }
            int numd = Convert.ToInt32(Math.Pow(10,n-1));//находим число которое нам нужно сначала вычесть
            int numdc = numd;//сохраняем его в отд ельную переменную, которую не будем менять
            Console.WriteLine(mnum);//вывод первой строчки
            while (numd != numc)//цикл вывода матрицы
            {
                mnum = mnum - numd + (numc-numd);/*изменение числа, логика была такой, что все числа перед 4 и сама четверка уменьшаются
                от строчки к строчке, а после четверки увеличиваются на 1*/
                Console.WriteLine(mnum);// вывод измененного число
                numd = numdc + numd/10;
            }
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
            Console.WriteLine("Номер 2.2");
            Console.WriteLine("Вводите числа");
            int num1t = Convert.ToInt32(Console.ReadLine());//получаем числа
            int num2t = Convert.ToInt32(Console.ReadLine());//получем числа
            string num1 = Convert.ToString(num1t,2);//конвертируем в двоичную
            string num2 = Convert.ToString(num2t,2);//конвертируем в двоичную
            string sum = Convert.ToString(num1t + num2t,2);//получаем двоичную сумму
            string Lt = "";//строчка отделающая ответ от примера
            while(num1.Length < sum.Length)//цикл уравнение разрядности
            {
                num1 = '0' + num1;
            }
            while(num2.Length<sum.Length)//цикл уравнения разрядности
            {
                num2 = '0' + num2;
            }
            for (int ct =0;ct!=(sum.Length);ct++)
            {
                Lt +='.';
            }
            Console.WriteLine(num1);
            Console.WriteLine(num2);
            Console.WriteLine(Lt);
            Console.WriteLine(Convert.ToString(num1t + num2t,2));
            Console.WriteLine("Номер 1.4");
            int h = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i<=h; i++)
            {
                for (int t = 0; t <= h-i; t++)
                {
                    Console.Write(' ');
                }
                int v = 1;
                for (int j = 0; j <=i; j++)
                {
                    if (j == 0 || i == 0)
                    {
                        Console.Write('1'+ " ");
                    }
                    else
                    {
                        v = v*(i-j+1)/j;
                        Console.Write(v + " ");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine("Номер 2.3");
            Console.WriteLine("Введите числа");
            int n1 = Convert.ToInt16(Console.ReadLine());
            int n2 = Convert.ToInt16(Console.ReadLine());
            int n3 = Convert.ToInt16(Console.ReadLine());
            int n4 = Convert.ToInt16(Console.ReadLine());
            long nl = 0;
            int [] ar = new int[4];
            ar[0] = n4;
            ar[1] = n3;
            ar[2] = n2;
            ar[3] = n1;
            for (int i = 0; i <= 3; i++)
            {
                string n_in_2 = Convert.ToString(ar[i],2);
                for(int j = 1; j<=n_in_2.Length;j++)
                {
                    if (n_in_2[^j] == '1')
                    {
                        nl += (long)Math.Pow(2,(j-1+16*(3-i)));
                    }
                }
            }
            Console.WriteLine(nl);
        }
    }
}


