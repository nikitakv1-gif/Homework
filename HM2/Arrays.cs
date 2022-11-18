using System;

namespace HM2
{
    class Solution
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Номер 3.2");
            int len = Convert.ToInt32(Console.ReadLine());
            int num = Convert.ToInt32(Console.ReadLine()) - 1;
            int[] arr = new int[len];
            Console.WriteLine("Ввод массива через Enter");
            for (int i = 0; i < len; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int b = 0; b < len; b++)
            {
                for (int i = 0; i < len-1; i++)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        int c = arr[i];
                        arr[i] = arr[i + 1];
                        arr[i + 1] = c;
                    }
                }
            }
            Console.WriteLine(arr[num]);
            Console.WriteLine("Номер 3.3");
            int len1 = Convert.ToInt32(Console.ReadLine());
            int[] arr1 = new int[len1];
            Console.WriteLine(arr1.Length);
            for (int t = 0; t < arr1.Length; t++)
            {
                arr1[t] = Convert.ToInt32(Console.ReadLine());
            }
            string num1 = Console.ReadLine();
            int k = 0;
            string st = "";
            string ed = "";
            string step = "";
            for (int y = 0; y <num1.Length; y++)
            {
                if (num1[y] != ':')
                {
                    switch (k)
                    {
                        case 0:
                            st += num1[y];
                            break;
                        case 1:
                            ed += num1[y];
                            break;
                        case 2:
                            step += num1[y];
                            break;
                    }
                }
                else
                    k += 1;
            }
            int start = Convert.ToInt32(st);
            int finish = Convert.ToInt32(ed);
            int istep = Convert.ToInt32(step);
            if (istep > 0)
            {
                int j = start;
                while (j <= finish)
                {
                    Console.Write(Convert.ToString(arr1[j]) + ' ');
                    j += istep;
                }
            }
            else
            {
                int j = finish;
                while (j >= start)
                {
                    Console.Write(Convert.ToString(arr1[j]) + ' ');
                    j += istep;
                }
            }
        }
    }
}
