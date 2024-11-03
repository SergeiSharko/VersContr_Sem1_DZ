// Задача 3: Задайте массив из вещественных чисел с ненулевой дробной частью. Найдите
// разницу между максимальным и минимальным элементов массива.
// Пример
// массив [2.2 0.4 9.11 7.2 78.98] => 78.58
// массив [1.22 4.5 3.33] => 3.28

double[] array = new double[5];
double minElement,
       maxElement;
Random rand = new Random();

for (int i = 0; i < array.Length; i++)
    array[i] = Math.Round(rand.Next(100) + rand.NextDouble(), 2);

minElement = maxElement = array[0];
for (int i = 0; i < array.Length; i++)
{
    if (minElement > array[i]) minElement = array[i];
    if (maxElement < array[i]) maxElement = array[i];
}

Console.WriteLine($"Исходный массив:");
Console.WriteLine(string.Join(" ", array));

Console.Write($" => {maxElement} - {minElement} = {maxElement - minElement}");
