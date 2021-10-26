using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static int[] InsertationSort(int[] Mass)
        {
            int[] El = new int[Mass.Length];
            for (int x = 0; x < Mass.Length; x++)
            {
                int y = x;
                while (y > 0 && El[y - 1] > Mass[x])
                {
                    El[y] = El[y - 1];
                    y--;
                }
                El[y] = Mass[x];
            }
            return El;
        }

        static int f = 0;
        static int p = 0;
        static int c = 0;
        static float g = 0;
        static int k = 0;

        static void Main(string[] args)
        {
            int[] mass = {2,2,2,2,2};
            // Odinakovoy chisla in massiv.
            for (int q = 0; q < mass.Length; q++)
            {
                if (q + 1 < mass.Length)
                {
                    if (mass[q] == mass[q + 1])
                    {
                        f++;
                    }
                }
            }

            if (f == mass.Length - 1)
            {
                Console.WriteLine("Массив имеет недопустимый вид");
                
            }
            

            // 1 double number.
            for (int t = 0; t < mass.Length; t++)
            {

                for (int u = t + 1; u < mass.Length; u++)
                    if (mass[t] == mass[u])
                    {
                        p++;
                    }
                if (p == 1)
                {
                    Console.WriteLine("Массив имеет одну пару чисел");
                    break;
                }

            }
            // 2 double number.
            for (int i = 0; i < mass.Length; i++)
            {
                InsertationSort(mass);
                for (int o = i + 1; o < mass.Length; o++)
                {
                    if (mass[i] == mass[o])
                    {
                        c++;
                    }
                }
            }
            if (c == 2)
            {
                Console.WriteLine("Массив имеет две пары чисел");
            }
            // Polnie number
            for (int x = 0; x < mass.Length; x++)
            {
                if (mass[x] != g)
                {
                    Console.WriteLine("Массив имеет полные числа");
                    break;
                }
            }
            // 3x2 or 2x3
            for (int x = 0; x < mass.Length; x++)
            {
                for (int i = x + 1; i < mass.Length; i++)
                {
                    if (mass[x] > mass[i])
                    {
                        k = mass[x];
                        mass[x] = mass[i];
                        mass[i] = k;

                    }

                }

            }

            for (int y = 0; y < mass.Length; y++)
            {
                if (mass.Length == 5)
                {
                    if (mass[2] < mass[3] || mass[1] < mass[2])
                    {
                        Console.WriteLine("Массив имеет вариант 3х2");
                        break;
                    }
                }

            }

            Console.ReadLine();
        }
    }
}
