Console.WriteLine("Введите номер четверти");
int number = int.Parse(Console.ReadLine());
if (number == 1)
{
    Console.WriteLine("Диапазоны для возможных координат X>0, Y>0");
}
else if (number == 2)
{
    Console.WriteLine("Диапазоны для возможных координат X<0, Y>0");
}
else if (number == 3)
{
    Console.WriteLine("Диапазоны для возможных координат X<0, Y<0");
}
else
{
    Console.WriteLine("Диапазоны для возможных координат X>0, Y<0");
}