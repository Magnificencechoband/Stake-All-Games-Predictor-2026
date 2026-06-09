using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter your name:");
        string name = Console.ReadLine();
        
        Console.WriteLine("Enter your age:");
        int age = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine($"Hello, {name}! You are {age} years old.");
        
        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}