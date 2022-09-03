Console.Write("Введите число: ");
string a = Console.ReadLine();
int number = Convert.ToInt32(a);

if (number %2 == 0)
{
    Console.WriteLine("Да, число четное");
}
else
{
    Console.WriteLine("Нет, число нечетное");
}