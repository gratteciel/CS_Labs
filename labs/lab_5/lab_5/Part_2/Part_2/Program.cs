using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Part_2_2();
        }
        static void Part_2_1()
        {
            Console.WriteLine("Hello, you will need to choose a character");
            Console.WriteLine("To start with:");
            char startChar = Console.ReadKey().KeyChar;
            Console.WriteLine("\nTo end with:");
            char endChar = Console.ReadKey().KeyChar;
            Console.WriteLine();

            DataClasses1DataContext data = new DataClasses1DataContext();
            var query = from c in data.cities
                        where c.Name.StartsWith(startChar.ToString()) && c.Name.EndsWith(endChar.ToString())
                        select c;

            foreach (var city in query)
            {
                Console.WriteLine(city.Name);
            }
        }
        static void Part_2_2()
        {
            Console.WriteLine("Input the value above you want to display the members of the List ");
            int result = int.Parse(Console.ReadLine());
            DataClasses2DataContext data = new DataClasses2DataContext();
            var query = from n in data.Numbers where n.number >result select n;
            Console.WriteLine("The numbers greater than "+ result +" are :");
            foreach (var nu in query)
            {
                Console.WriteLine("The Member " + nu.Id.ToString() +" with the number :" + nu.number.ToString());
            }

        }
        //for the following part it was almost the same and I've already did a lot of databases
    }
}
