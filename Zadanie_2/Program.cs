Console.WriteLine("Введите первое число");
int one_number=int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число");
int two_number=int.Parse(Console.ReadLine());
Console.WriteLine("Введите третье число");
int three_number=int.Parse(Console.ReadLine());
int max;
if (one_number>two_number)
    max=one_number;
else if(two_number>three_number)
    max=two_number;
else
    max=three_number;
Console.WriteLine("Максимальное число: " + max);