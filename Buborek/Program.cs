using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buborek
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] t = new int[] { 4, 5, 8, 2, 3, 9, 2, 6, 1 };

            Console.WriteLine("Buborék rendezés");

            for (int i = t.Length - 1; i >= 1; i--)
            {
                for (int j = 0; j <= i - 1; j++)
                {
                    if (t[j] > t[j + 1])
                    {
                        int temp = t[j];
                        t[j] = t[j + 1];
                        t[j + 1] = temp;
                    }
                }
            }

            foreach (var item in t)
            {
                Console.Write($"{item} ");
            }

            Console.ReadKey();
        }
    }
}
