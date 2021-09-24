using System;

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
        
        private static int PowerFunction(int x)
        {
            return (int)(Math.Pow(x, 2) - 4);
        }

        public static void Exo1()
        {
            //Exo 1 Question 1
            Console.WriteLine("Exo 1 Question 1 :");
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
            Console.WriteLine("Exo 1 Question 2 :");
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
            Console.WriteLine("Exo 1 Question 3 :");
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
            Console.WriteLine("Exo 2 Question 1 :");
            bool verif;
            for (int numberN = 1; numberN <= 1000; numberN++)
            {
                verif = true;
                for (int i = 2; i < numberN; i++)
                {
                    if (numberN % i == 0)
                    {
                        verif = false;
                    }
                }
                if (verif == true)
                {
                    Console.WriteLine(numberN);
                }
            }
            //Exo 2 Question 2
            Console.WriteLine("Exo 2 Question 2 :");
            int number1 = 1;
            int number2 = 0;
            int numberFn = 0;

            while (number2 < 1000)
            {
                Console.WriteLine(numberFn);
                numberFn = number2 + number1;
                number1 = number2;
                number2 = numberFn;
            }
            //Exo 2 Question 3
            Console.WriteLine("Exo 2 Question 3 :");
            int result = 1;

            for (int number3 = AskUserForParameter(); number3 > 0; number3--)
            {
                result *= number3;
            }
            Console.WriteLine(result);
        }
        
        public static void Exo3()
        {
            //Exo 3
            Console.WriteLine("Exo 3 :");
            for (int number = -3; number <= 3; number++)
            {
                try
                {
                    Console.WriteLine(PowerFunction(number));
                }
                catch (Exception error)
                {
                    Console.WriteLine(error);
                    throw;
                }
            }
        }
        
        public static void Exo4()
        {
            //Exo 4
            Console.WriteLine("Exo 4 :");
            Console.WriteLine("Saisissez la longueur du rectangle puis la largeur séparée par un virgule :");
            string[] values = Console.ReadLine().Split(',');
            int longueur = int.Parse(values[0]);
            int largeur = int.Parse(values[1]);
            for (int n = 0; n < longueur; n++)
            {
                for (int m = 0; m < largeur; m++)
                {
                    if (n == 0 || n == longueur - 1)
                    {
                        if (m == 0 || m == largeur - 1)
                        {
                            Console.Write("0");
                        }
                        else
                        {
                            Console.Write("-");
                        }
                    }
                    else if (m == 0 || m == largeur - 1)
                    {
                        Console.Write("|");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
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
                    Exo2();
                }
                else if (exoNumber == 3)
                {
                    Exo3();
                }
                else if (exoNumber == 4)
                {
                    Exo4();
                }
                else if (exoNumber == 5)
                {
                    Console.WriteLine("Désolé je n'ai pas réussi à faire l'exo 5 !");
                    //Exo5();
                }
                Console.WriteLine();
            } while (exoNumber != 0);
        }
    }
}