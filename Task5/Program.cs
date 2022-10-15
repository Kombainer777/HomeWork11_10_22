// Найти сумму чисел одномерного массива стоящих на нечетной позиции
Console.WriteLine("Введите количество элементов массива");
int size = int.Parse(Console.ReadLine());
int [] arr = new int [size];

for (int i = 0; i < size; i++)
    arr[i] = new Random().Next(0,100);

Console.WriteLine("Ваш массив: ");
for (int i = 0; i < size; i++)
    Console.Write($"{arr[i]} ");
int sum = 0;
for (int i = 0; i < size; i = i + 2) //Считаем элемент с индексом 0 стоит на нечетной позиции (для пользователя эта позиция равна 1)
    sum = sum + arr[i];
Console.WriteLine();
Console.WriteLine($"Сумма чисел массива, стоящих на нечетной позиции равна: {sum}");
