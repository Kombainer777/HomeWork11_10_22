// В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]
int size = 123;
int [] arr = new int [size];

for (int i = 0; i < size; i++)
    arr[i] = new Random().Next(0,1000);

Console.WriteLine("Ваш массив: ");
for (int i = 0; i < size; i++)
    Console.Write($"{arr[i]} ");
int count = 0;
for (int i = 0; i < size; i++)
{
    if(arr[i] >= 10 && arr[i] <=99)
        count++;
}
Console.WriteLine();
Console.WriteLine($"Количество чиселиз отрезка [10,99] в массиве равно: {count}");
