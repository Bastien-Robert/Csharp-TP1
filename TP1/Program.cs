using System;
using System.Data;

namespace TP1
{
    class Program
    {
        private static int AskUserForParameter()
        {
            Console.WriteLine("Please write a number and press enter :");
            int.TryParse(Console.ReadLine(), out var result);
            return result;
        }
        
        public static void Exo1()
        {
            //Exo 1 Question 1
            Console.WriteLine("Question 1 :");
            for (int number1 = 1; number1 < 11; number1++)
            {
                Console.WriteLine($"Table of {number1}");
                for (int number2 = 1; number2 < 11; number2++)
                {
                    Console.WriteLine($"{number1} x {number2} = {number1 * number2}");
                }

                Console.WriteLine();
            }
            //Exo 1 Question 2
            Console.WriteLine("Question 2 :");
            for (int number1 = 1; number1 < 11; number1++)
            {
                Console.WriteLine($"Table of {number1}");
                for (int number2 = 1; number2 < 11; number2++)
                {
                    if ((number1 * number2) % 2 != 0)
                    {
                        Console.WriteLine($"{number1} x {number2} = {number1 * number2}");
                    }
                }

                Console.WriteLine();
            }
            //Exo 1 Question 3
            Console.WriteLine("Question 3 :");
            int userNumber;
            do
            {
                userNumber = AskUserForParameter();
            } while (userNumber > 1000);

            Console.WriteLine($"Table of {userNumber}");
            for (int number2 = 1; number2 < 11; number2++)
            {
                Console.WriteLine($"{userNumber} x {number2} = {userNumber * number2}");
            }

            Console.WriteLine();
        }

        public static void Exo2()
        {
            //Exo 2 Question 1
            Console.WriteLine("Question 1 :");
            
        }

        static void Main(string[] args)
        {
            int exoNumber;
            do
            {
                Console.WriteLine("0 - EXIT");
                Console.WriteLine("1 - Exo 1");
                Console.WriteLine("2 - Exo 2");
                Console.WriteLine("3 - Exo 3");
                Console.WriteLine("4 - Exo 4");
                Console.WriteLine("5 - Exo 5");
                Console.WriteLine("What exercise do you want to run ?");
                int.TryParse(Console.ReadLine(), out exoNumber);
                if (exoNumber == 0)
                {
                    Console.WriteLine("EXIT...");
                }
                else if (exoNumber == 1)
                {
                    Exo1();
                }
                else if (exoNumber == 2)
                {
                    //Exo2();
                }
                else if (exoNumber == 3)
                {
                    //Exo3();
                }
                else if (exoNumber == 4)
                {
                    //Exo4();
                }
                else if (exoNumber == 5)
                {
                    //Exo5();
                }
            } while (exoNumber != 0);
        }
    }
}