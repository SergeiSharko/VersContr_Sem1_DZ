// Задача 2: Задайте массив на 10 целых чисел. Напишите программу, которая определяет
// количество чётных чисел в массиве.
// Пример
// массив [6 7 19 34 3 1 4 7 9 1] => 3
// массив [1 8 43 4 55 60 3 2 1 3] => 4

int[] array = new int[10];
int countEven = 0;
Random rand = new Random();

for (int i = 0; i < array.Length; i++)
    array[i] = rand.Next(1, 100);

for (int i = 0; i < array.Length; i++)
{
    if (array[i] % 2 == 0) countEven++;
}

Console.WriteLine($"Исходный массив:");
Console.WriteLine(string.Join(" ", array));

if (countEven == 0)
    Console.Write($" => Четных элементов в массиве нет!");
else
    Console.Write($" => {countEven} четных элементов в массиве");


