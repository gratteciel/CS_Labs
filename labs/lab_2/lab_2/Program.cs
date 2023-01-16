using System;
using System.Collections.Generic;
using lab_2.Employee;

namespace lab_2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //Ex1();
            //Ex2();
            Ex3();


        }

        public static void Ex1()
        {
            int x1, y1, z1;
            int choice;
            Console.WriteLine("Creating 2 2D Vectors and 3D Vectors, 2 default and 2 parametrized");
            Console.WriteLine("Enter 2 values for the first vector");
            Console.Write("x :");
            x1 = int.Parse(Console.ReadLine());
            Console.Write("y :");
            y1 = int.Parse(Console.ReadLine());
            Vectors2D v1 = new Vectors2D(x1,y1);
            Console.WriteLine("Enter 2 values for the second vector");
            Console.Write("x :");
            x1 = int.Parse(Console.ReadLine());
            Console.Write("y :");
            y1 = int.Parse(Console.ReadLine());
            Vectors2D v2= new Vectors2D(x1,y1);
            Console.WriteLine("Enter z value for the third vector, will take x and y from the first vector");
            Console.Write("z :");
            z1 = int.Parse(Console.ReadLine());
            Vectors3D v3 = new Vectors3D(v1.X,v1.Y,z1);
            Console.WriteLine("Enter z value for the third vector, will take x and y from the first vector");
            Console.Write("z :");
            z1 = int.Parse(Console.ReadLine());
            Vectors3D v4 = new Vectors3D(v2.X,v2.Y,z1);
            
            Console.WriteLine("Which Vector do you want to calculate the norm");
            Console.Write("Your choice :");
            choice = Int32.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("The norm : " + v1.Norm());
                    break;
                case 2:
                    Console.WriteLine("The norm : " + v2.Norm());
                    break; 
                case 3:
                    Console.WriteLine("The norm : " + v3.Norm());
                    break; 
                case 4:
                    Console.WriteLine("The norm : " + v4.Norm());
                    break;
                default:
                    break;
                
            }
            Console.WriteLine("Which Vector do you want to know if the values are equals ");
            Console.Write("Your choice :");
            choice = Int32.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.WriteLine("They're equals : " + v1.Vectors2D_equals()); 
                    break;
                case 2:
                    Console.WriteLine("They're equals : " + v2.Vectors2D_equals()); 
                    break; 
                case 3:
                    Console.WriteLine("They're equals : " + v3.equals()); 
                    break; 
                case 4:
                    Console.WriteLine("They're equals : " + v4.equals()); 
                    break;
                default:
                    break;
                
            }
            Console.WriteLine("We've defined " + v1.Counter + " vectors");
            
        }

        public static void Ex2()
        {
            List<Person.Person> listPerson = new List<Person.Person>();
            listPerson.Add(new Person.Employe("Emilian","Mitu",21,2500));
            listPerson.Add(new Person.Employe("Jonas","le low",21,2000));
            listPerson.Add(new Person.Employe("Vincent","Pompei",21,2100));
            listPerson.Add(new Person.Employe("Auguste","Bauer",21,200));
            listPerson.Add(new Person.Employe("Jacky","Chan",21,265));
            listPerson.Add(new Person.Manager(new Person.Person("Csharp","Le boss",21),2340,"mathematics"));
            listPerson.Add(new Person.Manager(new Person.Person("Not","Found",23),3400,"machine learning"));
            listPerson.Add(new Person.Director(new Person.Person("Emma","Waston", 22),4000,"huge","Google"));

            foreach (var var in listPerson)
            {
                Console.WriteLine("///////////////////");
                var.Display();
            }
        }


        public static void Ex3()
        {
            List<Employee.Employee> listEmployee = new List<Employee.Employee>();
            listEmployee.Add(new Worker(1,"Vincent", "TEST", new DateTime(2002,12,12),3));
            listEmployee.Add(new Worker(2,"Best", "WORKER", new DateTime(1990,01,11),9));
            listEmployee.Add(new Executive(3,"James","CARTER",new DateTime(1998,09,21),3));
            listEmployee.Add(new Executive(4,"James","CARTER",new DateTime(1997,09,15),2));
            listEmployee.Add(new Executive(5,"William","CAMERON",new DateTime(1986,02,27),1));
            listEmployee.Add(new Boss(6,"Emilian","MITU",new DateTime(2001,11,14),20,120));
            
            foreach (var var in listEmployee)
            {
                Console.WriteLine("///////////////////");
                var.ex3_toString();
            }
        }

        public static void Ex4()
        {
            
            
        }
    }
}