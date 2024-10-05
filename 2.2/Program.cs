Console.WriteLine("--- Введіть рік ---");
int year = Int32.Parse(Console.ReadLine());

 if (year <= 0)
{
    Console.WriteLine("--- Некоректний ввід ---");
}
else if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
{
    Console.WriteLine($"Рік ({year}) є високосним.");
}
else
{
    Console.WriteLine($"Рік ({year}) не є високосним.");
}


