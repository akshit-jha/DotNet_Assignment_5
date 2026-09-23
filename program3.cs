using System;

class Program3
{
    static void Main3()
    {
        int[] numbers = { 10, 20, 30, 40, 50 };

        try
        {
            Console.Write("Enter an index (0-4): ");
            int index = int.Parse(Console.ReadLine());

            Console.WriteLine("Value = " + numbers[index]);
        }
        catch (IndexOutOfRangeException)
        {
            Console.WriteLine("Error: Index is outside the array range.");
        }
        catch (FormatException)
        {
            Console.WriteLine("Error: Please enter a valid integer.");
        }
    }
}