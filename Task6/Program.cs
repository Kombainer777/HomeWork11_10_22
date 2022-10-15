// Найти произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д.
Console.WriteLine("Введите количество элементов массива");
int size = int.Parse(Console.ReadLine());
int [] arr = new int [size];

for (int i = 0; i < size; i++)
    arr[i] = new Random().Next(0,100);

Console.WriteLine("Ваш массив: ");
for (int i = 0; i < size; i++)
    Console.Write($"{arr[i]} ");
int min = 0;
int max = size - 1;
int count = 0;
int multi = 0;
while (min < max)
{
    multi=arr[min] * arr[max];
    count++;
    min++;
    max--;
    Console.WriteLine();
    Console.WriteLine($"Произведение чисел {count} пары равно {multi}");
}
