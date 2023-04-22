Console.WriteLine("Введите число");
int one_number=int.Parse(Console.ReadLine());
int count=1;
while (count<=one_number)
{
    if (count%2==0)
        Console.Write(count+", ");
    count+=1;
}