using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conditionals_structures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // everything I've learned about conditionals structures and a BMI calculator

            #region what are conditionals structures?
            /*
             
            the conditional structures enables the program to make decisions and change the execution flow.
            
            it's like telling the computer: "run A case X is false; or B case A for false; otherwise, 
        run B".

            a condition may be true or false.

            uses equality or relational operators
             
             */
            #endregion

            #region if / else
            /*
             
            int value = 10;

            if(value==5) 
            {
	            Console.WriteLine("True");
            }

            else
            {
            Console.WriteLine("False");
            } 

            [in the case, the console show "False"]
             
             */
            #endregion

            #region chained (if - else if - else)
            /*
             
            if(value==5)
            {
	            Console.WriteLine("True");
            }

            else if(value==10)
            {
            Console.WriteLine("Alternative");
            }

            else
            {
            Console.WriteLine("False");
            }

            [it confers two or more conditions]

             */
            #endregion

            #region within structure 
            /*
             
        number = 20;

        if(number > 5)
	    {
		Console.WriteLine("it is greater than 5");
		
		if (number % 2 == 0)
		{
			Console.WriteLine("and it's also an even number");
		else
		{
			Console.WriteLine(", bat it's odd");
		}
	}

            [it's possible add chained structure]
             
             */
            #endregion

            #region BMI calculator

            // the first question is going to be weight and height

            Console.Write("Inform your weight: ");
                double weight = double.Parse(Console.ReadLine());

            Console.Write("Inform your height in meters: ");
                double height = double.Parse(Console.ReadLine());

            Console.Clear(); // cleaning form

            // now, let's calculate!

            double bmi = weight / (height * height);

            // the computer will judge the user's weight with conditionals structures
           
            if (bmi > 18.50 && bmi < 24.99)
            {
                Console.WriteLine(bmi + "kg/m² -- Ideal weight.");
            }

            else if (bmi >= 24.99)
            {
                Console.WriteLine(bmi + "kg/m² -- Alert! Over ideal weight.");
            }

            else
            {
                Console.WriteLine(bmi + "kg/m² -- Alert! Under ideal weight.");
            }

            Console.WriteLine("Finish! Press a key to exit.");
            Console.ReadKey();

            #endregion
        }
    }
}
