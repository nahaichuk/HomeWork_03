int x = 5;
int y = 2;
int sum = 0;

String result = "0";

for (int i = Math.Min(x, y); i <= Math.Max(x, y); i++)
{
    sum = sum + i;
    result = result + " + " + i.ToString();
}
Console.WriteLine(result + " = " + sum.ToString());


Console.Write("Введите число x: ");
string? x1 = Console.ReadLine();

if (x1 == "")
{   
    Console.Clear();
}

Console.Write("Введите число y: ");
string? y1 = Console.ReadLine();
if (y1 == "")
{
    Console.Clear();
}

if (y1 != "" & x1 != "")
{
    Console.WriteLine($"Установлено значение X:{x1} а Y: {y1}");
}

