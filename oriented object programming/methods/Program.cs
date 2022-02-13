using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Methods m1 = new Methods();
            m1.Somar(5, 10);

            Console.ReadKey();
            Console.Clear();

            int value1 = 100;
            int value2 = 200;

            m1.IncreaseValue(value1);
            m1.IncreaseRef(ref value2);

            Console.WriteLine();

            Console.WriteLine("Value: " + value1);
            Console.WriteLine("Reference: " + value2);

            Console.WriteLine("Press to next");
            Console.ReadKey();

            Console.Clear();

            string fullName = m1.RideName("Guilherme", "Rodrigues");
            Console.WriteLine(fullName);

            int character = m1.CharCode('a');
            Console.WriteLine(character);

            char character2 = m1.CharCode2('a');
            Console.WriteLine(character2);

            double pi = m1.PiValue();
            Console.WriteLine(pi);

            int value3 = 10;
            m1.IncreaseValue2(value3);
            Console.WriteLine("Value: " + value3);

            Console.WriteLine("Press to next");
            Console.ReadKey();
               
        }
    }
}
