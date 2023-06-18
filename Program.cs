int chislo = ReadInt("Введите число: ");
int count = chislo.ToString().Length;
Console.Write(ChiSlo(chislo, count));

int ReadInt(string message)
{
Console.Write(message);
return Convert.ToInt32(Console.ReadLine());
}

int ChiSlo(int a, int b)
{
int chiselo = 0;
if (b < 3)
{
Console.Write("Третьей цифры нет ---->");
}
else
{
int z = 1;
for (int i = b; i > 3; i--)
{
z = z * 10;
}

chiselo = (a / z) % 10;
}
return chiselo;
}
