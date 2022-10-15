// Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетных\четных чисел
Console.WriteLine("Введите количество элементов массива");
int size = int.Parse(Console.ReadLine());
int [] arr = new int [size];

for (int i = 0; i < size; i++)
    arr[i] = new Random().Next(100,1000);

Console.WriteLine("Ваш массив: ");
for (int i = 0; i < size; i++)
    Console.Write($"{arr[i]} ");
int count1 = 0;
int count2 = 0;
for (int i = 0; i < size; i++)
{
    if(arr[i] % 2 == 0)
        count1++;
    else
        count2++;
}
Console.WriteLine();
Console.WriteLine($"Количество четных чисел в массиве равно: {count1}");
Console.WriteLine();
Console.WriteLine($"Количество нечетных чисел в массиве равно: {count2}");
