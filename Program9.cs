using System;
using System.IO;

class Program9
{
    static void Main9()
    {
        string fileName = "student.txt";

        try
        {
            
            using (StreamWriter writer = new StreamWriter(fileName))
            {
                writer.WriteLine("Student Name: Akshit");
                writer.WriteLine("Roll Number: 101");
                writer.WriteLine("Course: MCA");
                writer.WriteLine("Marks: 85");
            }

            Console.WriteLine("Student details written successfully.\n");

            
            using (StreamReader reader = new StreamReader(fileName))
            {
                string data = reader.ReadToEnd();

                Console.WriteLine("Student Details:");
                Console.WriteLine(data);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }
}