var name = "Ewa";
var gender = "female";
var age = 33;

if (age < 30 && gender == "female")
{
    Console.WriteLine("Kobieta poniżej 30 lat.");
}
else if (name == "Ewa" && age == 33)
{
    Console.WriteLine("Ewa, lat 33.");
}
else if (age < 18 && gender != "female")
{
    Console.WriteLine("Niepełnoletni mężczyzna.");
}
else
{
    Console.WriteLine("Przykro nam, nie mamy takiej osoby w bazie.");
}