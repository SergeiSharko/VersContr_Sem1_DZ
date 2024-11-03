// Задача 1: Задайте одномерный массив из 10 целых чисел от 1 до 100.
// Найдите количество элементов массива, значения которых лежат в отрезке [20,90].
// Пример
// массив [10 21 14 93 23] => 2

int[] array = new int[10];
int count = 0;
Random rand = new Random();

for (int i = 0; i < array.Length; i++)
{
    array[i] = rand.Next(1, 100);
}

for (int i = 0; i < array.Length; i++)
{
    if (array[i] >= 20 && array[i] <= 90) count++;
}

Console.WriteLine("Исходный массив:");
Console.WriteLine(string join(" ", array));;

if (count == 0)
    Console.Write($" => Нет элементов из отрезка [20,90]");
else 
    Console.Write($" => {count} элементов из отрезка [20,90]");