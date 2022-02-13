using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methods
{
    internal class Methods
    {
        public void Greet()
        {
            Console.WriteLine("Hello! Welcome!");
        }

        public void Somar(int num1, int num2)
        {
            int result = num1 + num2;
            Console.WriteLine("The result of the sum is " + result);
        }

        public void IncreaseValue(int value)
        {
            value += 10;
            Console.WriteLine("Final value is " + value);
        }

        public void IncreaseRef(ref int value)
        {
            value += 10;
            Console.WriteLine("Final value reference is " + value);
        }

        public string RideName(string firstName, string lastName)
        {
            string fullName = firstName + " " + lastName;
            return fullName;
        }

        public int CharCode(char character)
        {
            return character;
        }

        public char CharCode2(char character2)
        {
            return character2;
        }

        public double PiValue()
        {
            return 3.1415;
        }

        public int IncreaseValue2(int value)
        {
            value += 10;
            Console.WriteLine("Final value is " + value);
            return value;
        }


    }
}
