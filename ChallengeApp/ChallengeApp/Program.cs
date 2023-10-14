var number          = 4566;
var numberInString  = number.ToString();                // "4566"
List<char> signs    = new List<char>(numberInString);   // '4', '5', '6', '6'
var counter         = 0;

for (int i = 0; i < 10; i++)
{
    foreach (char sign in signs)
    {
        if (sign.ToString() == i.ToString())
        {
            counter++;
        }
    }
    Console.WriteLine(i + " => " + counter);
    counter = 0;
}