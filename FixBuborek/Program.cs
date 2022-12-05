using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace FixBuborek
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] t = new int[80000];

            Console.WriteLine("Javított buborék");

            Beolvas(t);

            Stopwatch stopper = new Stopwatch();

            int i = t.Length - 1;

            stopper.Start();

            while (i >= 1)
            {
                int cs = -1;
                for (int j = 0; j <= i - 1; j++)
                {
                    if (t[j] > t[j + 1])
                    {
                        int temp = t[j];
                        t[j] = t[j + 1];
                        t[j + 1] = temp;
                        cs = j;
                    }
                }
                i = cs;
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
