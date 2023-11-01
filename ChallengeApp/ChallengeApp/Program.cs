using ChallengeApp;

Console.WriteLine("==============================");
Console.WriteLine("Welcome to The X Files Project");
Console.WriteLine("==============================");
Console.WriteLine("Numeric scale: 0 - 100. Letter scale: A - E.");
Console.WriteLine("Press 'q' to finish adding grades and view statistics.");

var employee = new EmployeeInFile("Adam", "Nowak", 38, 'M');
employee.GradeAdded += EmployeeGradeAdded;

void EmployeeGradeAdded(object sender, EventArgs args)
{
    Console.WriteLine("Grade added succesfully!");
}

while (true)
{
    Console.Write("\nPlease enter the next employee's grade: ");
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
Console.WriteLine($"Total amount of correct grades: {statistics.Count}");
Console.WriteLine($"Sum of correct grades: {statistics.Sum:N2}");
Console.WriteLine($"Average: {statistics.Average:N2}");
Console.WriteLine($"AverageLetter: {statistics.AverageLetter}");
Console.WriteLine($"Min: {statistics.Min:N2}");
Console.WriteLine($"Max: {statistics.Max:N2}");