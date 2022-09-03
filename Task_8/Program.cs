Console.Write("N= ");
string a = Console.ReadLine();
int N = Convert.ToInt32(a);

int n = 1;

while (n < N)
{
    if (n % 2 == 0)
    {
        Console.Write(n + ",");
    }
    n++;
}
