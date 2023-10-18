using ChallengeApp;

Employee employee1 = new("Adam", "Nowak", 38);
Employee employee2 = new("Monika", "Kowalska", 27);
Employee employee3 = new("Zuzia", "Grabowska", 19);

employee1.AddScore(5);
employee1.AddScore(9);
employee1.AddScore(8);  // 26
employee1.AddScore(1);
employee1.AddScore(3);

employee2.AddScore(2);
employee2.AddScore(5);
employee2.AddScore(1);  // 22
employee2.AddScore(4);
employee2.AddScore(10);

employee3.AddScore(8);
employee3.AddScore(1);
employee3.AddScore(7);  // 31
employee3.AddScore(8);
employee3.AddScore(7);

List<Employee> employees = new()
{
    employee1, employee2, employee3
};

int maxResult = -1;
Employee? employeeWithMaxResult = null;

foreach (var employee in employees)
{
    if(employee.Result > maxResult)
    {
        maxResult = employee.Result;
        employeeWithMaxResult = employee;
    }
}

Console.WriteLine("Najwyższa liczba punktów: "
    + maxResult
    + ". \nPracownik, który ją osiągnął to "
    + employeeWithMaxResult.Name
    + " "
    + employeeWithMaxResult.Surname
    + " w wieku "
    + employeeWithMaxResult.Age
    + " lat.");