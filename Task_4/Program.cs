Console.Write("a= ");
string first = Console.ReadLine();
int a = Convert.ToInt32(first);
Console.Write("b= ");
string second = Console.ReadLine();
int b = Convert.ToInt32(second);
Console.Write("c= ");
string third = Console.ReadLine();
int c = Convert.ToInt32(third);
int max = a;

if (a > max)
{
    max = a;
}
if (b > max)
{
    max = b;
}
if (c > max)
{
    max = c;
}

Console.Write("max= ");
Console.WriteLine(max);