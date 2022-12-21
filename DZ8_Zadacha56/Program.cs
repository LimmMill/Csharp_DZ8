// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Console.WriteLine("Введите количетсво строк массива");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количетсво столбцов массива");
int b = Convert.ToInt32(Console.ReadLine());
if (a == 0 || b == 0)

{ Console.WriteLine("значение столбцов и строк не равно 0!"); }
Console.WriteLine();
int[,] array = new int[a, b];
CreateArray(array);
PrintArray(array);
Console.WriteLine();

void CreateArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i, j],2}");
        Console.WriteLine();
    }
}
int[] CountArray(int[,] array)
{
    int[] sumarray = new int[a];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i, j];
        }
        int res = sum;
        sumarray[i] = res;
        Console.Write($"{res,2}; ");
    }
    return sumarray;
}
void Findstr()
{
    int[] result = CountArray(array);
    int temp = 0;
    int help = result[0];
    for (int i = 0; i < result.Length-1; i++)
    {
         if (result[i] < help)
        {
            help = result[i];
            temp = i;
        }
    }
Console.WriteLine($"номер строки с наименьшей суммой элементов:{temp+1}");
}
Findstr();
