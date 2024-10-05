Console.WriteLine("--- Введіть одну літеру ---");

char letter = char.ToUpper(Console.ReadKey().KeyChar); 
string vowels = "AEIOU";

if (vowels.Contains(letter))
{
    Console.WriteLine("\n Це голосна літера.");
}
else
{
    Console.WriteLine("\n Це приголосна літера.");
}