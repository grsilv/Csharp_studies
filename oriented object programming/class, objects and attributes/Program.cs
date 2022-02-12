using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class__objects_and_attributes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person();

            Console.WriteLine("#PERSON 1");
            Console.WriteLine();

            Console.Write("First Name: ");
            p1.firstname = Console.ReadLine();

            Console.Write("Last Name: ");
            p1.lastname = Console.ReadLine();

            Console.Write("Age: ");
            p1.age = int.Parse(Console.ReadLine());

            Console.Clear();

            Person p2 = new Person();

            Console.WriteLine("#PERSON 2");
            Console.WriteLine();

            Console.Write("First Name: ");
            p2.firstname = Console.ReadLine();

            Console.Write("Last Name: ");
            p2.lastname = Console.ReadLine();

            Console.Write("Age: ");
            p2.age = int.Parse(Console.ReadLine());

            Console.Clear();

            OtherClass o1 = new OtherClass();
            o1.a = 1;

            Console.Clear();

            Console.WriteLine("Person 1: " + p1.firstname + " " + p1.lastname + ", and they has " + p1.age + " years old.");
                Console.WriteLine();
            Console.WriteLine("Person 2: " + p2.firstname + " " + p2.lastname + ", and they has " + p2.age + " years old.");
                Console.WriteLine();
            Console.WriteLine("Press to next");
            
            Console.ReadKey();

            Console.WriteLine("Other class: " + o1.a);
            Console.WriteLine("Press to finish");

            Console.ReadKey();

        }
    }
}

class Person
{
    public string firstname;
    public string lastname;
    public int age;
}
