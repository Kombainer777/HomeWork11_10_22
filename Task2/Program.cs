// Задать массив из 12 элементов, заполненных числами из [0,9]. Найти сумму положительных/отрицательных элементов массива
int size = 12;
int [] arr = new int [size];

for (int i = 0; i < size; i++)
    arr[i] = new Random().Next(-10,10);

Console.WriteLine("Ваш массив: ");
for (int i = 0; i < size; i++)
    Console.Write($"{arr[i]} ");
int sum1 = 0;
int sum2 = 0;
for (int i = 0; i < size; i++)
{
    if(arr[i] >= 0)
        sum1 = sum1 + arr[i];
    else
        sum2 = sum2 + arr[i];
}
Console.WriteLine();
Console.WriteLine($"Сумма положительных чисел в массиве равна: {sum1}");
Console.WriteLine();
Console.WriteLine($"Сумма отрицательных чисел в массиве равна: {sum2}");