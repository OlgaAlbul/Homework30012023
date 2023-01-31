Console.WriteLine("Введите число A");
int numberA = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число B");
int numberB = int.Parse(Console.ReadLine());
if (numberA ==numberB*numberB)
{
    Console.WriteLine("Первое число является квадратом второго");
}
else if (numberB == numberA*numberA)
{
    Console.WriteLine("Второе число является квадратом первого");
}
else
{
    Console.WriteLine("Ни одно из чисел не является квадротом другого");
}
