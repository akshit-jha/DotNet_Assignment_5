using System;

class Program4
{
    static void Main4()
    {
        try
        {
            Console.Write("Enter first number: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Enter second number: ");
            int b = int.Parse(Console.ReadLine());

            int result = a / b;

            Console.WriteLine("Result = " + result);
        }
        catch (FormatException)
        {
            Console.WriteLine("Error: Invalid numeric format.");
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Error: Cannot divide by zero.");
        }
        catch (Exception)
        {
            Console.WriteLine("Error: Some other exception occurred.");
        }
    }
}