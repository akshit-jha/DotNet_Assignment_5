using System;

class Program1
{
    static void Main1()
    {
        try
        {
            Console.Write("Enter first integer: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter second integer: ");
            int b = Convert.ToInt32(Console.ReadLine());

            int result = a / b;

            Console.WriteLine("Result = " + result);
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Error: Cannot divide by zero.");
        }
    }
}