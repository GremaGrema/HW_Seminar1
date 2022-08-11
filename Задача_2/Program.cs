Console.Write ("Введите первое число: ");
int numberA = int.Parse(Console.ReadLine());
Console.Write ("Введите второе число: ");
int numberB = int.Parse(Console.ReadLine());
if (numberA == numberB)
Console.Write($"Числа {numberB} и {numberA} равны");
else
if (numberA > numberB)
Console.Write($"Число {numberA} больше, а число {numberB} меньше");
else
Console.Write($"Число {numberB} больше, а число {numberA} меньше");
