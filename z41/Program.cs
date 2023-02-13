Console.Clear();
Console.WriteLine("Введите числа. Для остановки ввода - введите 0");
int n = Convert.ToInt32(Console.ReadLine()), m = 0;
if (n > 0)
    m = m +1;
while (n != 0)
{
    n = Convert.ToInt32(Console.ReadLine());
    if (n > 0)
    m = m +1;
}
Console.WriteLine(m);

