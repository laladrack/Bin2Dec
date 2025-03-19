using static System.Runtime.InteropServices.JavaScript.JSType;

Console.WriteLine("Input binary value: ");
string numStr = Console.ReadLine();

string[] numbers = {"2", "3","4", "5", "6", "7", "8", "9"};

//check if inputed value is valid
if (numStr.Length < 1 || numStr.Length > 8)
{
    Console.WriteLine("Invalid binary number.");
    Environment.Exit(0);
}
else if (numbers.Any(numStr.Contains))
{
    Console.WriteLine("Invalid binary number.");
    Environment.Exit(0);
}
else
{
    for (int i = 0; i < numStr.Length; i++)
    {
        if (Char.IsNumber(numStr[i]) == false)
        {
            Console.WriteLine("Invalid binary number.");
            Environment.Exit(0);
        }
    }
}

//converts user input to integer
int num = int.Parse(numStr);
int deci = 0;
int base1 = 1;

//creates decimal number
while (num > 0)
{
    int digit = num % 10;
    deci += digit * base1;

    num = num / 10;
    base1 = base1 * 2;
}

Console.WriteLine($"Decimal number: {deci}");