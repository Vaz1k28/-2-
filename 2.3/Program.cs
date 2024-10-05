Console.WriteLine("--- Введіть число ---");
int money = Int32.Parse(Console.ReadLine());
double b = 0;


if (money > 0)
{
    if (money < 30000) {
        b = money * 0.9;
    Console.WriteLine(b);
    } 
    else if ((money > 29999) & (money < 90000)) { 
        b = money * 0.83;
    Console.WriteLine(b);
    }
    else if ((money > 89999) & (money < 200000)) { 
        b = money * 0.75;
        Console.WriteLine(b);
    }
    else if ((money > 19999) & (money < 500000)) { 
        b = money * 0.68;
        Console.WriteLine(b);
    }
    else if (money > 499999) { 
        b = money * 0.60;
        Console.WriteLine(b);
    }
}
else if (true)
    Console.WriteLine("--- Некоректний ввід ---");

