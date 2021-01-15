using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1 = 0, num2 = 0;

            Console.WriteLine("Calculator App\n\n");

            Console.WriteLine("Enter first input");
            num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter second input");
            num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter your option");
            Console.WriteLine("\t1.Add");
            Console.WriteLine("\t2.Subtract");
            Console.WriteLine("\t3.Multiply");
            Console.WriteLine("\t4.Divide");
            Console.WriteLine("\t5.Exit");
            Console.Write("option: ");

            int option = Convert.ToInt32(Console.ReadLine());

            switch(option)
            {
                case 1:
                    Console.WriteLine($"\nThe result is {num1} + {num2} = " + (num1 + num2));
                    break;
                case 2:
                    Console.WriteLine($"\nThe result is {num1} - {num2} = " + (num1 - num2));
                    break;
                case 3:
                    Console.WriteLine($"\nThe result is {num1} * {num2} = " + (num1 * num2));
                    break;
                case 4:
                    while(num2 == 0)
                    {
                        Console.WriteLine("Please enter a non zero input");
                        num2 = Convert.ToDouble(Console.ReadLine());
                    }
                    Console.WriteLine($"\nThe result is {num1} / {num2} = " + (num1 / num2));
                    break;
                case 5:
                    Console.WriteLine($"\nThank you for using Calculator App");
                    break;
            }
        }
    }
}
