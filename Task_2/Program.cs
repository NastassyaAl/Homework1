Console.Write("a= ");
string first = Console.ReadLine();
int a = Convert.ToInt32(first);
Console.Write("b= ");
string second = Console.ReadLine();
int b = Convert.ToInt32(second);
int max = 0;

if (a > b)
{
    max = a;
}
else
{
    max = b;
}

Console.Write("max= ");
Console.WriteLine(max);