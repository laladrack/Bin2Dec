Console.WriteLine("Input binary value: ");
string numStr = Console.ReadLine();

int num = int.Parse(numStr);
string[] numbers = {"2", "3","4", "5", "6", "7", "8", "9"};

if (numStr.Length < 1 || numStr.Length > 8)
{
    Console.WriteLine("Invalid binary number.");
    Environment.ExitCode = 1;
}
else if (numbers.Any(numStr.Contains)){
    Console.WriteLine("Invalid binary number.");
    Environment.ExitCode = 1;
}