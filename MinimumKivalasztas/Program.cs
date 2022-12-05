using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinimumKivalasztas
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] t = new int[80000];

            Beolvas(t);

            Stopwatch stopper = new Stopwatch();

            Console.WriteLine("Minimum kiválasztás");

            stopper.Start();

            for (int i = 0; i <= t.Length - 1; i++)
            {
                int min = i;
                for (int j = i + 1; j < t.Length; j++)
                {
                    if (t[min] > t[j])
                    {
                        min = j;
                    }
                }
                int temp = t[i];
                t[i] = t[min];
                t[min] = temp;
            }

            stopper.Stop();

            //foreach (var item in t)
            //{
            //    Console.Write($"{item} ");
            //}

            Console.WriteLine(stopper.ElapsedMilliseconds);

            Console.ReadKey();
        }

        private static void Beolvas(int[] t)
        {
            using (StreamReader sr = new StreamReader("adatok.txt"))
            {
                int i = 0;
                while (!sr.EndOfStream)
                {
                    t[i++] = Convert.ToInt32(sr.ReadLine());
                }
            }
        }
    }
}
