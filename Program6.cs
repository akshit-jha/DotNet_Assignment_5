using System;

class Program6
{
    static void Main6()
    {
        int[] marks = new int[5];

        try
        {
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Enter marks for subject " + (i + 1) + ": ");
                marks[i] = int.Parse(Console.ReadLine());

                if (marks[i] < 0 || marks[i] > 100)
                {
                    throw new Exception("Marks must be between 0 and 100.");
                }
            }

            Console.WriteLine("\nMarks entered successfully.");

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Subject " + (i + 1) + ": " + marks[i]);
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Error: Please enter numeric marks only.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }
}