using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_objects_attributes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person();

            p1.firstName = "Percy";
            p1.lastName = "Jackson";
            p1.age = 12;

            Person p2 = new Person()
            {
                firstName = "Annabeth",
                lastName = "Chase",
                age = 12
            };

            OtherClass other = new OtherClass();
                other.number = 1;
            OtherClass other2 = other;

            Console.WriteLine("Person 1: " + p1.firstName + " " + p1.lastName + "; " + p1.age + " years old"); ;
                Console.WriteLine("Press to next");
                    Console.ReadKey();

            Console.WriteLine();

            Console.WriteLine("Person 2: " + p2.firstName + " " + p2.lastName + "; " + p2.age + " years old"); ;
                 Console.WriteLine("Press to next");
                    Console.ReadKey();

            Console.Clear();

            Console.WriteLine("###OTHER CLASS###");
                Console.WriteLine("Other1: " + other);
                    Console.WriteLine("Other2: " + other2);
                        Console.WriteLine("Press to finish");
                             Console.ReadKey();
        }

        class Person
        {
            public string firstName;
            public string lastName;
            public int age;
        }

    }
}
