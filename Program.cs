using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Student Grade Analyzer");
        Console.WriteLine("Enter grades separated by commas:");

        string input = Console.ReadLine() ?? "";

        if (string.IsNullOrWhiteSpace(input))
        {
            Console.WriteLine("Input cannot be empty.");
            return;
        }

        string[] parts = input.Split(',');

        Console.WriteLine($"You entered {parts.Length} grades.");
    }
}