using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;


/*
 *I made a menu for differents exercices 
 *
 * 
 */
namespace lab1
{
    internal class Program
    {
        public static void Main(string[] args)
        {

            Console.Write("Select what part do you want to choose (I/II/III/IV : ");
            string choose1 = Console.ReadLine();
            string choose2;
            switch (choose1)
            {
                case "I":
                    Console.Write("Select what part do you want to choose (I/II/III/IV : ");
                    choose2 = Console.ReadLine();
                    switch (choose2)
                    {
                        case "I":
                            Part1Ex1();
                            break;
                        case "II":
                            Part1Ex2();
                            break;
                        case "III":
                            Part1Ex3();
                            break;
                        case "IV":
                            Part1Ex4();
                            break;
                        
                    }
                    break;
                case "II":
                    Console.Write("Select what part do you want to choose (I/II/III/IV : ");
                    choose2 = Console.ReadLine();
                    switch (choose2)
                    {
                        case "I":
                            Part2Ex1();
                            break;
                        case "II":
                            Part2Ex2();
                            break;
                        case "III":
                            Part2Ex3();
                            break;
                        case "IV":
                            Part2Ex4();
                            break;
                        
                    }
                    break;
                case "III":
                    Console.Write("Select what part do you want to choose (I/II : ");
                    choose2 = Console.ReadLine();
                    switch (choose2)
                    {
                        case "I":
                            Part3Ex1();
                            break;
                        case "II":
                            Part3Ex2();
                            break;                        
                    }
                    break;
                case "IV":
                    Console.Write("Select what part do you want to choose (I : ");
                    choose2 = Console.ReadLine();
                    switch (choose2)
                    {
                        case "I":
                            Console.WriteLine("There are 3 programs in this exercise, choose what you want:");
                            Console.WriteLine("1 : Valid integer");
                            Console.WriteLine("2 : Valid date of birth");
                            Console.WriteLine("1 : Valid departure and arrival date");
                            int choice = int.Parse(Console.ReadLine());
                            switch (choice)
                            {
                                case 1: 
                                    Part4Ex1Integer();
                                    break;
                                case 2:
                                    Part4Ex1DateOfBirth();
                                    break;
                                case 3: 
                                    Part4Ex1DepartureArrival();
                                    break;
                                default:
                                    Console.WriteLine("Invalid input !");
                                    break;
                            }
                            break;
                    }
                    break;
                default:
                    Console.WriteLine("Error");
                    break;
                
            }



        }

        public static void Part1Ex1()
        {
            Console.WriteLine("Enter a price");
            int price = int.Parse(Console.ReadLine());
            Console.WriteLine("How much did you pay");
            int paid = int.Parse(Console.ReadLine());
            int total = paid - price;
            int i = 0;
            do
            {
                if (total >= 100)
                {
                    Console.WriteLine("100");
                    total = total - 100;
                }

                else if (total >= 50)
                {
                    Console.WriteLine("50");
                    total = total - 50;
                }
                else if (total >= 20)
                {
                    Console.WriteLine("20");
                    total = total - 20;
                }
                else if (total >= 10)
                {
                    Console.WriteLine("10");
                    total = total - 10;
                }
                else if (total >= 5)
                {
                    Console.WriteLine("5");
                    total = total - 5;
                }
                else if (total >= 2)
                {
                    Console.WriteLine("2");
                    total = total - 2;
                }
                else if (total >= 1)
                {
                    Console.WriteLine("1");
                    total = total - 1;
                }
                else
                {
                    Console.WriteLine("You can't afford it");
                    return;
                }
            } while (total != 0);
        }

        public static void Part1Ex2()
        {
            Console.WriteLine("Enter a number of data points");
            int enterPoints = int.Parse(Console.ReadLine());
            var array = new List<int>();
            float arithmetic = 0;
            float median = 0;
            int mode = 0;
            double standard_deviation = 0;
            for (int i = 0; i < enterPoints; i++)
            {
                Console.Write("[" + i + "] :");
                array.Add(int.Parse(Console.ReadLine()));
                arithmetic += Convert.ToSingle(array[i]);
            }

            array.Sort();
            int middleIndex = array.Count / 2;
            if (array.Count % 2 == 1) //If the count is Odd
            {
                median = Convert.ToSingle(array[middleIndex]);
            }
            else
            {
                median = Convert.ToSingle(array[middleIndex - 1] + array[middleIndex]) / 2;
            }

            arithmetic = arithmetic / array.Count;
            int maxFrequency = 0;
            foreach (int state in array)
            {
                int frequency = array.Count(x => x == state);
                if (frequency > maxFrequency)
                {
                    mode = state;
                    maxFrequency = frequency;
                }
            }

            if (array.Any())
            {
                // Compute the average.     
                double avg = array.Average();

                // Perform the Sum of (value-avg)_2_2.      
                double sum = array.Sum(x => Math.Pow(x - avg, 2));

                // Put it all together.      
                standard_deviation = Math.Sqrt((sum) / (array.Count() - 1));
            }
            

            Console.WriteLine("Statistical Information :");
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("Arithmetic Mean : " + arithmetic);
            Console.WriteLine("Median: " + median);
            Console.WriteLine("Mode :" + mode);
            Console.WriteLine("Standard deviation :" + standard_deviation);
        }
        public static void Part1Ex3()
        {
            
            Console.WriteLine("Select now what type of conversion do you want to use:  ");
            Console.WriteLine("I -> convert from inches to centimeters");
            Console.WriteLine("G -> convert from gallons to liters.");
            Console.WriteLine("M -> convert from mile to kilometer.");
            Console.WriteLine("P -> convert from pound to kilogram.");
            char choice = char.Parse(Console.ReadLine());
            int value; 

            switch (choice)
            { 
                    
                case 'I':
                    Console.WriteLine("Type a value for inches:");
                    value = int.Parse(Console.ReadLine());
                    Console.WriteLine("The final value is : " + value*2.34);
                    break;
                case 'G':
                    Console.WriteLine("Type a value for gallons:");
                    value = int.Parse(Console.ReadLine());
                    Console.WriteLine("The final value is : " + value*3.78541);
                    break;
                case 'M':
                    Console.WriteLine("Type a value for miles:");
                    value = int.Parse(Console.ReadLine());
                    Console.WriteLine("The final value is : " + value*1.60934);
                    break;
                case 'P':
                    Console.WriteLine("Type a value for pound:");
                    value = int.Parse(Console.ReadLine());
                    Console.WriteLine("The final value is : " + value*0.453592);
                    break;
                default:
                    Console.WriteLine("Error of input choice");
                    Thread.Sleep(3000);
                    Console.Clear();
                    Part1Ex3();
                    break;
                
            }
        }

        public static void Part1Ex4()
        {
            
            Console.WriteLine("Enter coordinates : ");
            Console.Write("x : ");
            double centerX = double.Parse(Console.ReadLine());
            Console.Write("y : ");
            double centerY = double.Parse(Console.ReadLine());
            Console.Write("radius : ");
            double radius = double.Parse(Console.ReadLine());
            
            Console.WriteLine("Now we'll check if the point is in the circle");
            
            Console.Write("Type the an x: ");
            double pointX = double.Parse(Console.ReadLine());
            Console.Write("Type the an y : ");
            double pointY = double.Parse(Console.ReadLine());
            
            double distance = Math.Sqrt(Math.Pow(pointX - centerX, 2) + Math.Pow(pointY - centerY, 2));

            if (distance > radius)
            {
                Console.WriteLine("The point lies outside the circle.");
            }
            else if (distance == radius)
            {
                Console.WriteLine("The point lies on the circle.");
            }
            else
            {
                Console.WriteLine("The point lies inside the circle.");
            }
            
            
            

        }

        public static void Part2Ex1()
        {
            Console.Write("Enter the first value : ");
            int value1 = int.Parse(Console.ReadLine());
            Console.Write("Enter the second value : ");
            int value2 = int.Parse(Console.ReadLine());
            Console.Write("Enter a string : ");
            string str = Console.ReadLine();
            
            
            var age = GetInt(str, value1, value2);
        }
        private static int GetInt(string str, int value1, int value2)
        {
            int result = 0;
            int value;

            do
            {
                Console.Write(str + " : ");
                 value = int.Parse(Console.ReadLine());
                 if (value > value2)
                 {
                     Console.WriteLine("Not a valid answer. Must be no more than " + value2);
                     
                 }
                 else if (value1 > value)
                 {
                     Console.WriteLine("Not a valid answer. Must be no less than " + value1);
                 }
            } while (value > value2 || value1 > value);
            
            
            return result;
        }

        public static void Part2Ex2()
        {
            int value;
            int result; 
            do
            {
                Console.Write("Enter a number for factorial : ");
                value = int.Parse(Console.ReadLine());
            } while (value < 0);


            result = Factorial(value);
            Console.WriteLine("Final value is: " + result);
        }
        private static int Factorial(int value)
        {
            if (value == 0)
            {
                return 1;
            }
            else
            {
                return value * Factorial(value - 1);
            }
                
        }
        
        public static void Part2Ex3()
        {
            int value;
            int result; 
            do
            {
                Console.Write("Enter a number for Fibonnaci : ");
                value = int.Parse(Console.ReadLine());
            } while (value < 0);


            Console.WriteLine("Value entered " + value);
            result = Fibonnaci(value);
            Console.WriteLine("Final value is: " + result);
        }
        private static int Fibonnaci(int value)
        {
            if (value == 0)
            {
                return 0;
            }
            else if (value == 1)
            {
                return 1;
            }
            else
            {
                return Fibonnaci(value - 1) + Fibonnaci(value - 2);
            }
        }

        public static void Part2Ex4()
        {

            Random random = new Random();
            
            Console.WriteLine("Select a difficulty ");
            int randomNumber = random.Next(1, 6);
            Console.WriteLine("Select a difficulty for how many attempt : 1 / 2 / 3");
            int input;
            do
            {
                Console.Write("Your choice : ");
                 input = int.Parse(Console.ReadLine());
            } while (input < 0 || input > 3);
            do
            {
                Console.WriteLine("Guess the number");
                Console.Write("What is the number : ");
                int guess = int.Parse(Console.ReadLine());
                if (guess == randomNumber)
                {
                    Console.WriteLine("Good job you find the good value, the random number was : " + randomNumber );
                    
                }
                else
                {
                    Console.WriteLine("Wrong number");
                }
                input--; 
                if (input != 0)
                {
                    Console.WriteLine("Try Again!");
                    
                }
                else
                {
                    Console.WriteLine("You failed !");
                }
                

               

            } while (input != 0);
            
            
            Console.WriteLine("The correct number was : " + randomNumber);


        }

        public static void Part3Ex1()
        {
            int[,] array = new int[5, 5];
            int rows = array.GetLength(0);
            int columns = array.GetLength(1);
            int k = 1;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    array[i, j] = k;
                    k++;

                }
                
            }
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }

        }

        public static void Part3Ex2()
        {
            Console.Write("We'll do a Pascal triangle, what size do you want : ");
            int size = int.Parse(Console.ReadLine());
            int[,] triangle = new int[size, size];
            //they are equals 
            int rows = triangle.GetLength(0);
            int columns = triangle.GetLength(1);
            

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (i == 0 || j == 0 || i == j)
                    {
                        triangle[i, j] = 1;
                    }
                    else
                    {
                        triangle[i, j] = triangle[i - 1, j - 1] + triangle[i - 1, j];
                    }
                }
            }
            // Print the triangle
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write(triangle[i, j] + " ");
                }
                Console.WriteLine();
            }
            
        }

        public static void Part4Ex1Integer()
        {
            int numberInt = 0;
            while (true)
            {
                try
                {
                    Console.WriteLine("Enter an integer");
                    numberInt = int.Parse(Console.ReadLine());
                    break;

                }
                catch (Exception e)
                {
                    Console.WriteLine("Please enter a valid integer");
                    Console.WriteLine(e);
                }
            }
            Console.WriteLine("You entered the integer : " + numberInt);
        }
        public static void Part4Ex1DateOfBirth()
        {
            DateTime input;
            while (true)
            {
                try
                {
                    Console.WriteLine("Enter your date of birth");
                    input = DateTime.Parse(Console.ReadLine());
                    break;

                }
                catch (Exception e)
                {
                    Console.WriteLine("Please enter a valid date");
                    Console.WriteLine(e.Message);
                }
            }
            Console.WriteLine("You entered the date : " + input);
        }
        public static void Part4Ex1DepartureArrival()
        {
            DateTime departure;
            DateTime arrival;
            while (true)
            {
                try
                {
                    Console.WriteLine("Enter a departure date (dd/mm/yyyy)");
                    departure = DateTime.Parse(Console.ReadLine());
                    Console.WriteLine("Enter an arrival date (dd/mm/yyyy)");
                    arrival = DateTime.Parse(Console.ReadLine());
                    if (arrival < departure)
                    {
                        throw new Exception("The arrival date cannot be earlier than the departure date.");
                        
                    }
                    break;

                }
                catch (Exception e)
                {
                    
                    Console.WriteLine("Please enter a valid date");
                    Console.WriteLine(e.Message);
                }
            }
            Console.WriteLine("You entered the departure date  : " + departure);
            Console.WriteLine("And the arrival date  : " + arrival);
        }
        
        
    }
}