using ChallengeApp;

var employee1 = new Employee("Adam", "Nowak", 38);
// var employee2 = new Employee("Monika", "Kowalska", 27);
// var employee3 = new Employee("Zuzia", "Grabowska", 19);

employee1.AddGrade("Maciej");
employee1.AddGrade('l');
employee1.AddGrade(5000);
employee1.AddGrade(-36);
employee1.AddGrade(68);
employee1.AddGrade(23.11);
employee1.AddGrade(41.34534653456);
employee1.AddGrade(99);

employee1.GradesCounter();

//employee2.AddGrade(2);
//employee2.AddGrade(5);
//employee2.AddGrade(1);  // 22
//employee2.AddGrade(4);
//employee2.AddGrade(10);

//employee3.AddGrade(8);
//employee3.AddGrade(1);
//employee3.AddGrade(7);  // 31
//employee3.AddGrade(8);
//employee3.AddGrade(7);

var statistics  = employee1.GetStatistics();
var statistics1 = employee1.GetStatisticsWithForEach();
var statistics2 = employee1.GetStatisticsWithFor();
var statistics3 = employee1.GetStatisticsWithDoWhile();
var statistics4 = employee1.GetStatisticsWithWhile();

Console.WriteLine("\n--------------");
Console.WriteLine("GetStatistics:");
Console.WriteLine("--------------");
Console.WriteLine($"Average: {statistics.Average:N2}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");

Console.WriteLine("\n-------------------------");
Console.WriteLine("GetStatisticsWithForEach:");
Console.WriteLine("-------------------------");
Console.WriteLine($"Average: {statistics1.Average:N2}");
Console.WriteLine($"Min: {statistics1.Min}");
Console.WriteLine($"Max: {statistics1.Max}");

Console.WriteLine("\n---------------------");
Console.WriteLine("GetStatisticsWithFor:");
Console.WriteLine("---------------------");
Console.WriteLine($"Average: {statistics2.Average:N2}");
Console.WriteLine($"Min: {statistics2.Min}");
Console.WriteLine($"Max: {statistics2.Max}");

Console.WriteLine("\n-------------------------");
Console.WriteLine("GetStatisticsWithDoWhile:");
Console.WriteLine("-------------------------");
Console.WriteLine($"Average: {statistics3.Average:N2}");
Console.WriteLine($"Min: {statistics3.Min}");
Console.WriteLine($"Max: {statistics3.Max}");

Console.WriteLine("\n-----------------------");
Console.WriteLine("GetStatisticsWithWhile:");
Console.WriteLine("-----------------------");
Console.WriteLine($"Average: {statistics4.Average:N2}");
Console.WriteLine($"Min: {statistics4.Min}");
Console.WriteLine($"Max: {statistics4.Max}");