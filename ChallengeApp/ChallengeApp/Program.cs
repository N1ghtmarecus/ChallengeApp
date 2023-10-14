Console.Write("Wprowadź liczbę, którą chcesz sprawdzić: ");
var number = Console.ReadLine();
List<char> signs = new List<char>(number);
var counter = 0;

for (int i = 0; i < 10; i++)
{
    foreach (char sign in signs)
    {
        if (sign.ToString() == i.ToString())
        {
            counter++;
        }
    }
    if (counter == 0)
        Console.WriteLine("Cyfra " + i + " nie występuje! ");
    else if (counter == 1)
        Console.WriteLine("Cyfra " + i + " występuje tylko " + counter + " raz.");
    else
    {
        Console.WriteLine("Cyfra " + i + " występuje " + counter + " razy.");
    }
    counter = 0;
}