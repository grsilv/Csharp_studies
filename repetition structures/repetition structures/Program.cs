using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace repetition_structures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // in this session, we will have while, do while, for and foreach. As a bonus, a fibonacci sequence

            #region while
            /*
             int value = 0;

            while(valor < 10) # if value is less than 10, repeat
            {
            Console.WriteLine("This number is " + value);
            value++;
            }

            # will repeat until it reaches 10
            # if the condition is false, it will not execute
             */
            #endregion

            #region do while
            /*
                
            int value = 11;

            do 
            {
                Console.WriteLine("The number is " + value);
                value++;

            } while(value < 10);
             
            # it executes at least once, regardless of wheter the condition is false or not
             */
            #endregion

            #region for
            /*
             
            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine("I: " + i);
            }

            # will show a sequence up to a certain amount of times

             */
            #endregion

            #region foreach
            /*
            
            string[] names = {"John", "Beverly", "David"}

            foreach(string name in names)
            {
                Console.WriteLine("Name: " + name);

            }
                
            # will display until the collection ends
            */
            #endregion

            #region fibonacci sequence

            Console.WriteLine("Enter the values: ");
                int values = int.Parse(Console.ReadLine());
                    Console.WriteLine("Fibonacci sequence with " + values + " sequence");

            int a = 0, b = 1, c = 0;

            for (int i = 0; i < values; i++)
            {
                if (i < values - 1) {

                Console.Write(a + ", ");

                }

                else
                {
                    Console.Write(a);
                }

                c = a + b;
                a = b;
                b = c;
            }

            Console.ReadKey();

            #endregion 


        }
    }
}
