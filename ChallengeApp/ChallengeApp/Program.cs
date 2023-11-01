using ChallengeApp;

Console.WriteLine("==============================");
Console.WriteLine("Welcome to The X Files Project");
Console.WriteLine("==============================");
Console.WriteLine();

var employee = new EmployeeInFile("Adam", "Nowak", 38, 'M');
employee.GradeAdded += EmployeeGradeAdded;

void EmployeeGradeAdded(object sender, EventArgs args)
{
    Console.WriteLine("Succesfull added grade!");
}

while (true)
{
    Console.Write("\nPlease enter the next employee's grade \n(or press 'q' to quit and see the statistics): ");
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
        Console.WriteLine($"Exeption catched: {ex.Message}");
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