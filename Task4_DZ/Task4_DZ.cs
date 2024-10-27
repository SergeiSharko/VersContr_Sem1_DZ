// Задача 4**(не обязательно): Дано натуральное число в диапазоне от 1 до 100 000.
// Создайте массив, состоящий из цифр этого числа. Старший разряд числа должен
// располагаться на 0-м индексе массива, младший – на последнем. Размер массива должен
// быть равен количеству цифр. 8741 => [8 7 4 1]

Console.Write($"Введите натуральное число от 1 до 100 000 -> ");
string? strNumber = Console.ReadLine();
int number = Convert.ToInt32(strNumber);

if (number < 1 || number > 100000)
{
    Console.WriteLine($"Введено неверное число!");
    return;
}

int[] array = new int[strNumber.Length];

Console.Write($"{number} => ");

int count = 0;
while (number > 0)
{
    array[array.Length - 1 - count] = number % 10;
    number /= 10;
    count++;
}

Console.Write($"[");
for (int k = 0; k < array.Length; k++)
{
    Console.Write($"{array[k]}");
    if (k == array.Length - 1) break;
    Console.Write($" ");
}
Console.Write($"]");