using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace marshrut_bit
{
    class Program
    {
        static void Main(string[] args)
        {
            string v, output = "";
            int n = 3, m = 6, s = 0;
            Console.Write("Введіть текст:");
            v = Console.ReadLine();
            char[,] arr = new char[3, 6];
            char[] vs = new char[18];
            vs = v.ToCharArray();

            for (int i = 0; i < m; i++)
                for (int j = 0; j < n; j++)
                    if (s < 18)
                    {
                        arr[j, i] = vs[s];
                        s++;
                    }

            for (int i = 0; i < n; i++)
                for (int j = 0; j < m; j++)
                    output += arr[i, j];

            Console.Clear();
            Console.WriteLine($"Зашифроване повідомлення: {output}");
            Console.WriteLine($"Розшифроване повідомлення: {v}");
            Console.ReadKey();
            
            //заверншення роботи
        }
    }
}
