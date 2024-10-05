Console.WriteLine("--- Введіть першу сторону трикутника (a) ---");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("--- Введіть другу сторону трикутника (b)---");
int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("--- Введіть трету сторону трикутника (c)---");
int c = Convert.ToInt32(Console.ReadLine());

if (a > b)
    if (a > c)
        Console.WriteLine("Найдовша сторона = a");
if (b > a)
    if (b > c)
        Console.WriteLine("Найдовша сторона = b");
if (c > b)
    if (c > a)
        Console.WriteLine("Найдовша сторона = c");