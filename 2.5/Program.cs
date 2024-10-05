Console.WriteLine("--- Введіть перше число ---");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("--- Введіть друге число ---");
int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("--- Введіть трете число ---");
int c = Convert.ToInt32(Console.ReadLine());

if (a>b)
    if(a>c)
        Console.WriteLine($"Максимальне число = {a}");
if (b > a)
    if (b > c)
        Console.WriteLine($"Максимальне число = {b}");
if (c > b)
    if (c > a)
        Console.WriteLine($"Максимальне число = {c}");
