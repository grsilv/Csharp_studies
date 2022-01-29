using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace control_structures
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // I'il talk about the switch case and the jump statement; then I will make a calculator

            #region switch-case
            /*
            # the switch case allows a different code block depending on the option chosen by the user
                # example:
                    
                Console.Write("Pick a number: ");
                int num = int.Parse(Console.ReadLine());
                
                switch(num)
                {
                    case 1:
                    Console.WriteLine("Option 1);
                        break; # the break serves to prevent the case from advacing to others cases

                    case 2:
                    Console.WriteLine("Option 2);
                        break;

                    case 3:
                    case 4:
                    Console.WriteLine("Option 3 and 4);
                        break; # if the break is not used, case will go ahead and print what is following, too

                    default: # the default is an output in case the option does not identify with any of the cases

                    } # switch-case end

                Console.WriteLine("End!);
             
             */
            #endregion

            #region jump statement
            /*

            # this statement is used to control the transfer of execution to a labeled statement within a program
                #example:

            swtich(option)

            case 1:
                x += 2;
                    break;

            case 2:
                x += 3;
                gotu case 1; # return to case 1
            */
            #endregion

            #region calculator
            Inicio: // defined the first label

            Console.Write("Enter the first number: "); // getting the data
                double fn = double.Parse(Console.ReadLine());

            Console.Write("Enter the second number: ");
                double sn = double.Parse(Console.ReadLine());
            
            OperatorQuestion:
            Console.Write("Select operator (+ - x /): ");
                string op = Console.ReadLine();

            double res = 0; // res mean result

            switch(op)
            {
                case "+":
                    res = fn + sn;
                    Console.WriteLine("The resulte is " + res);
                    break;

                case "-":
                    res = fn - sn;
                    Console.WriteLine("The resulte is " + res);
                    break;

                case "x":
                    res = fn * sn;
                    Console.WriteLine("The resulte is " + res);
                    break;

                case "/":
                    res = fn / sn;
                    Console.WriteLine("The resulte is " + res);
                    break;

                default:
                    Console.WriteLine("Invalid! Press a key...");
                        Console.ReadKey();
                            Console.Clear(); // will go back to the beginning
                    goto OperatorQuestion;
            }

        Question: // defined label for question recal
            Console.Write("Do you want to recalculate? (y/n): ");
            string recal = Console.ReadLine();

            switch (recal)
            {
                case "y":
                    Console.Clear();
                    goto Inicio;

                case "n":
                    Console.Clear();
                    break;

                default:
                    Console.Clear();
                    goto Question; 
            }

            Console.WriteLine("Press a key to end");
            Console.ReadKey();


            #endregion

        }
    }
}
