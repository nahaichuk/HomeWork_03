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
