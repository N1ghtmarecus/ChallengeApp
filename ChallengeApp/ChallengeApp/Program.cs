﻿using ChallengeApp;

Console.WriteLine("Welcome to The X Files Project");
Console.WriteLine("==============================");
Console.WriteLine();

EmployeeInFile employee = new EmployeeInFile("Adam", "Nowak", 38, 'M');

while (true)
{
    Console.Write("\nPlease enter the next supervisor's grade \n(or press 'q' to quit and see the statistics): ");
    var input = Console.ReadLine();
    if (input == "q")
    {
        break;
    }

    try
    {
        employee.AddGrade(input);
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Exeption cathced: {ex.Message}");
    }
}

var statistics = employee.GetStatistics();

Console.WriteLine("\n-----------");
Console.WriteLine("Statistics:");
Console.WriteLine("-----------");
Console.WriteLine($"Total amount of correct grades: {statistics.Total}");
Console.WriteLine($"Average: {statistics.Average:N2}");
Console.WriteLine($"AverageLetter: {statistics.AverageLetter}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");