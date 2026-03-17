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
        int[] grades = new int[parts.Length];

        for (int i = 0; i < parts.Length; i++)
        {
            if (!int.TryParse(parts[i].Trim(), out grades[i]))
            {
                Console.WriteLine("Invalid grade detected.");
                return;
            }
        }

        double average = GradeHelper.CalculateAverage(grades);

        Console.WriteLine($"You entered {grades.Length} grades.");
        Console.WriteLine($"Average: {average}");
    }
}