Console.Write ("Введите первое число: ");
int numberA = int.Parse(Console.ReadLine());
Console.Write ("Введите второе число: ");
int numberB = int.Parse(Console.ReadLine());
Console.Write ("Введите второе число: ");
int numberC = int.Parse(Console.ReadLine());

if (numberA == numberB)
{
    if (numberC == numberB)
    Console.Write("Числа равны");
}
else
    if (numberA > numberB)
    {
            if (numberA > numberC)
            Console.Write($"Число {numberA} больше");
    }
else
    if (numberB > numberC)
    {
                Console.Write($"Число {numberB} больше");
    }
    else            
    Console.Write($"Число {numberC} больше");

