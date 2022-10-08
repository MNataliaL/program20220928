Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int c = Convert.ToInt32(Console.ReadLine());

int max = a, min = b;

if(max < min)
{
max = b;
min = a;
}

if(max < c) max = c;
if(min > c) min = c;

Console.Write("max = ");
Console.WriteLine(max);

Console.Write("min = ");
Console.WriteLine(min);