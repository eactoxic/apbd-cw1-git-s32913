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
        int max = GradeHelper.CalculateMax(grades);
        int min = GradeHelper.CalculateMin(grades);

        Console.WriteLine($"Total grades entered: {grades.Length}");
        Console.WriteLine($"Average: {average}");
        Console.WriteLine($"Max: {max}");
        Console.WriteLine($"Min: {min}");
    }
}