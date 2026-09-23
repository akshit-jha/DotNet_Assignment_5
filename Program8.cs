using System;

class InsufficientBalanceException : Exception
{
    public InsufficientBalanceException(string message) : base(message)
    {
    }
}

class BankAccount
{
    double balance;

    public BankAccount(double balance)
    {
        this.balance = balance;
    }

    public void Withdraw(double amount)
    {
        if (amount > balance)
        {
            throw new InsufficientBalanceException(
                "Withdrawal amount exceeds available balance.");
        }

        balance = balance - amount;

        Console.WriteLine("Withdrawal successful.");
        Console.WriteLine("Remaining balance = " + balance);
    }
}

class Program8
{
    static void Main8()
    {
        try
        {
            Console.Write("Enter account balance: ");
            double balance = double.Parse(Console.ReadLine());

            BankAccount account = new BankAccount(balance);

            Console.Write("Enter withdrawal amount: ");
            double amount = double.Parse(Console.ReadLine());

            account.Withdraw(amount);
        }
        catch (InsufficientBalanceException ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
        catch (FormatException)
        {
            Console.WriteLine("Error: Enter valid numeric values.");
        }
        finally
        {
            Console.WriteLine("Transaction completed.");
        }
    }
}