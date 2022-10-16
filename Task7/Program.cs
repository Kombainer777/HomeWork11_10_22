// В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом
Console.WriteLine("Введите количество элементов массива");
int size = int.Parse(Console.ReadLine());
double [] arr = new double [size];

for (int i = 0; i < size; i++)
    arr[i] = new Random().NextDouble() * 10;

Console.WriteLine("Ваш массив: ");
for (int i = 0; i < size; i++)
    Console.Write($"{arr[i]} ");
int j = 0;                   //Пробовал через i, но программа выдавала ошибку: error CS0103: Имя "i" не существует в текущем контексте. Пришлось сделать кустарно, т.к не понял в чем дело и как это исправить
double min=arr[j];
double max=arr[j];

for (int i = 0; i<size; i++)
 {   
    if (min>arr[i])
        min=arr[i];
    else
    {
        if(max<arr[i])
        max=arr[i];
    }
}
Console.WriteLine();
Console.WriteLine($"Минимальное число массива равно: {min}");
Console.WriteLine();
Console.WriteLine($"Максимальное число массива равно {max}");
Console.WriteLine();
Console.WriteLine($"Разница между максимальным и минимальным элементами равна: {max-min}");