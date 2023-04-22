Console.WriteLine("Введите первое число");
int one_number=int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число");
int two_number=int.Parse(Console.ReadLine());
int max;
if (one_number>two_number)
    max=one_number;
else
    max=two_number;
Console.WriteLine("Максимальное число: " + max);


