using System;

class Program2
{
    static void Main2()
    {
        try
        {
            Console.Write("Enter an integer: ");
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine("You entered: " + number);
        }
        catch (FormatException)
        {
            Console.WriteLine("Error: Please enter a valid numeric value.");
        }
    }
}