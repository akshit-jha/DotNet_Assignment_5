using System;

class InvalidLoginException : Exception
{
    public InvalidLoginException(string message) : base(message)
    {
    }
}

class Program7
{
    static void Main7()
    {
        try
        {
            Console.Write("Enter username: ");
            string username = Console.ReadLine();

            Console.Write("Enter password: ");
            string password = Console.ReadLine();

            if (username != "admin" || password != "12345")
            {
                throw new InvalidLoginException("Invalid username or password.");
            }

            Console.WriteLine("Login successful.");
        }
        catch (InvalidLoginException ex)
        {
            Console.WriteLine("Login Error: " + ex.Message);
        }
    }
}