using System;

class Program
{
    static void Main()
    {
        int n1, n2;
        Console.WriteLine("Write 1st number");
        int.TryParse(Console.ReadLine(), out n1);
        Console.WriteLine("Write 2nd number");
        int.TryParse(Console.ReadLine(), out n2);
        int sum = n1 + n2;
        Console.WriteLine($" {n1} + {n2} = {sum}");
    }
}