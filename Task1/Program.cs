// Задать массив из 8 элементов и заполнить его нулями и единицами и вывести его на экран

int size = 8;
int [] arr = new int [size];

for (int i = 0; i < size; i++)
    arr[i] = new Random().Next(0,2);

Console.WriteLine("Ваш массив: ");
for (int i = 0; i < size; i++)
    Console.Write($"{arr[i]} ");