using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            int option = 0;

            Console.WriteLine("Calculator");
            Console.WriteLine("1: Sum\n2: Subtraction\n3: Multplication\n4: Division\n5: Close application");

            while (option != 5)
            {
                Console.Write("\nEnter the option: ");
                option = int.Parse(Console.ReadLine());


                if (option > 0 && option < 5)
                {
                    EOperation operation = (EOperation)option;

                    Console.WriteLine($"\n{operation.ToString()}");
                    Console.Write("Enter the first number: ");
                    double num1 = double.Parse(Console.ReadLine());
                    Console.Write("Enter the second number: ");
                    double num2 = double.Parse(Console.ReadLine());

                    double result = 0.0;

                    switch (operation)
                    {
                        case EOperation.Sum:
                            result = Sum(num1, num2);
                            break;
                        case EOperation.Subtraction:
                            result = Subtraction(num1, num2);
                            break;
                        case EOperation.Multiplication:
                            result = Multiplication(num1, num2);
                            break;
                        case EOperation.Division:
                            if (num2 != 0)
                            {
                                result = Division(num1, num2);
                            }
                            else
                            {
                                Console.WriteLine("Cannot divide by zero.");
                            }
                            break;
                    }

                    Console.WriteLine($"Result: {result:F2}");
                }
                else if (option == 5)
                {
                    Console.WriteLine("Finishing application...");
                }
                else
                {
                    Console.WriteLine("Enter a valid number!");
                    option = 0;
                }
            }

            Environment.Exit(0);
        }

        enum EOperation : int
        {
            Sum = 1,
            Subtraction = 2,
            Multiplication = 3,
            Division = 4
        }


        static double Sum(double num1, double num2)
        {
            return num1 + num2;
        }

        static double Subtraction(double num1, double num2)
        {
            return num1 - num2;
        }

        static double Multiplication(double num1, double num2)
        {
            return num1 * num2;
        }

        static double Division(double num1, double num2)
        {
            return num1 / num2;
        }
    }
}