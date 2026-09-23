using System;

class Program5
{
    static void Main5()
    {
        try
        {
            Console.Write("Enter account balance: ");
            double balance = double.Parse(Console.ReadLine());

            Console.Write("Enter withdrawal amount: ");
            double amount = double.Parse(Console.ReadLine());

            if (amount > balance)
            {
                throw new Exception("Insufficient balance.");
            }

            balance = balance - amount;

            Console.WriteLine("Withdrawal successful.");
            Console.WriteLine("Remaining balance = " + balance);
        }
        catch (FormatException)
        {
            Console.WriteLine("Error: Enter valid numeric values.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
        finally
        {
            Console.WriteLine("Thank you for using the ATM.");
        }
    }
}