using System;
using System.IO;

class Program10
{
    static void Main()
    {
        string fileName = "marks.txt";

        try
        {
            string[] lines = File.ReadAllLines(fileName);

            int total = 0;
            int highest = int.MinValue;
            int lowest = int.MaxValue;

            foreach (string line in lines)
            {
                int mark = int.Parse(line);

                total = total + mark;

                if (mark > highest)
                {
                    highest = mark;
                }

                if (mark < lowest)
                {
                    lowest = mark;
                }
            }

            double average = (double)total / lines.Length;

            Console.WriteLine("Total Marks = " + total);
            Console.WriteLine("Average Marks = " + average);
            Console.WriteLine("Highest Marks = " + highest);
            Console.WriteLine("Lowest Marks = " + lowest);
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("Error: marks.txt file not found.");
        }
        catch (FormatException)
        {
            Console.WriteLine("Error: File contains invalid marks.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }
}