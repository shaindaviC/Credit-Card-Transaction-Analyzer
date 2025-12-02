using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the tid:");
        string? tid = Console.ReadLine();
        if (tid == null)
        {
            Console.WriteLine("Transaction ID cannot be null.");
            return;
        }
        Console.WriteLine("Enter the Amount:");
        decimal amount = Convert.ToDecimal(Console.ReadLine());
        Console.WriteLine("is the tid is international:");
        bool isinternational = Convert.ToBoolean(Console.ReadLine());
        Console.WriteLine("Enter your rating");
        double customerrating = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter the transaction timestamp");
        DateTime transaction_timestamp = Convert.ToDateTime(Console.ReadLine());
        Console.WriteLine("Enter reward points:");
        int rewardpoints = Convert.ToInt32(Console.ReadLine());
    }
}