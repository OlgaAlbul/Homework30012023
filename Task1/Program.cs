Console.WriteLine("Введите число от 1 до 7");
int number = int.Parse(Console.ReadLine());
if (number < 6)
{
    Console.WriteLine("Не является выходным");
}
else 
{
    Console.WriteLine("Является выходным");
}