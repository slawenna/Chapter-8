using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task8._14
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal a = 0m;

            for (int i = 0; i < 50000000; i++)

            {

                a += 0.000001m;

            }

            Console.WriteLine(a);

            Console.ReadKey();

            

            float b = 0f;

            for (int i = 0; i < 50000000; i++)

            {

                b += 0.000001f;

            }

            Console.WriteLine(b);

            Console.ReadKey();

            

            double c = 0d;

            for (int i = 0; i < 50000000; i++)

            {

                c += 0.000001d;

            }

            Console.WriteLine(c);

            Console.ReadKey();
        }
    }
}
