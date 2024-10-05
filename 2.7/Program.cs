Console.WriteLine("--- Введіть число ---");
double a = double.Parse(Console.ReadLine());

if (a != 0)
{
    if (a % 2 == 0)
        Console.WriteLine("Число є парним");
    else
        Console.WriteLine("Число не парне");
    if (a % 3 == 0)
        Console.WriteLine("");
        Console.WriteLine("Число ділиться на 3");
}
else
    Console.WriteLine("--- Некоректний ввід ---");



