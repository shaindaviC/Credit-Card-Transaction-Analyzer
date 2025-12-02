using System;
class program
{
    static void Main()
    {
        Console.WriteLine("enter the T_id:");
        string t_id = Console.ReadLine();
        Console.WriteLine("Enter the Amount:");
        decimal amount = Convert.ToDecimal (Console.ReadLine());
        Console.WriteLine("is the T_id is international:");
        bool isinternational = Convert.ToBoolean(Console.ReadLine());
        Console.WriteLine("Enter your rating");
        double customerrating = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter the transaction timestamp");
        DateTime transaction timestamp =Convert.ToDateTime Console.ReadLine();
        Console.WriteLine("Enter reward points:");
        int rewardpoints =Convert.ToInt32(Console.ReadLine());
    }
}