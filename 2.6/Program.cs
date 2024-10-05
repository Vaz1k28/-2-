Console.WriteLine("--- Введіть кількість років ---");
int a = Convert.ToInt32(Console.ReadLine());

if (a > 0)
{
    if (a >= 12 && a <= 18)
    {
        Console.WriteLine("Ти підліток");
    }
    else
    {
        Console.WriteLine("Ти не підліток");
    }
}
else
{
    Console.WriteLine("--- Некоректний ввід ---");
}
