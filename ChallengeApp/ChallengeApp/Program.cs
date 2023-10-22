using ChallengeApp;

var employee1 = new Employee("Adam", "Nowak", 38);
var employee2 = new Employee("Monika", "Kowalska", 27);
var employee3 = new Employee("Zuzia", "Grabowska", 19);

employee1.AddGrade(5000);
employee1.AddGrade("9");
employee1.AddGrade("Maciej");  // 26
employee1.AddGrade('p');
employee1.AddGrade(3);

employee2.AddGrade(2);
employee2.AddGrade(5);
employee2.AddGrade(1);  // 22
employee2.AddGrade(4);
employee2.AddGrade(10);

employee3.AddGrade(8);
employee3.AddGrade(1);
employee3.AddGrade(7);  // 31
employee3.AddGrade(8);
employee3.AddGrade(7);

var statistics = employee1.GetStatistics();
Console.WriteLine($"Average: {statistics.Average:N2}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");