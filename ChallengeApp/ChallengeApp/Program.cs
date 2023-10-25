using ChallengeApp;

Console.WriteLine("Welcome The X Files Project");
Console.WriteLine("===========================");
Console.WriteLine();

var employee1 = new Employee("Adam", "Nowak", 38);

while (true)
{
    Console.Write("\nPlease enter the next employee's grade: ");
    var input = Console.ReadLine();
    if (input == "q")
    { 
        break; 
    }
    employee1.AddGrade(input);
}

employee1.GradesCounter();

var statistics = employee1.GetStatistics();

Console.WriteLine("\n--------------");
Console.WriteLine("Statistics:");
Console.WriteLine("--------------");
Console.WriteLine($"Average: {statistics.Average:N2}");
Console.WriteLine($"AverageLetter: {statistics.AverageLetter}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");