internal class Program
{
private static void Main(string[] args)
{
int Prompt(string message)
{
Console.Write(message);
string value = Console.ReadLine() ?? "";
int chislo = Convert.ToInt32(value);
return chislo;
}
int namba = Prompt("Введите число трехзначное");
if (namba < 100 || namba >= 1000)
{
Console.WriteLine($"Введено не трехначное число");
return;
}
Console.WriteLine($"Введено число >{namba}<");
int rezultat = namba / 10 % 10;
Console.WriteLine($"Введено число >{rezultat}<");
}
}
