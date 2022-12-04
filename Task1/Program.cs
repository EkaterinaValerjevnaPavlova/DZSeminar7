/*
Задача 47. Задайте двумерный массив размером m×n, 
заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/

int rows = ReadInt("Введите количество строк m: ");
int columns = ReadInt("Введите количество столбцов n: ");
double[,] nambers = new double[rows, columns];
FillMatrixRandomNumbers(nambers);
WriteMatrix(nambers);

void FillMatrixRandomNumbers(double[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0;j<array.GetLength(1); j++)
        {
            int randomNumber = new Random().Next(100, 1000);
            array[i,j] = Convert.ToDouble(randomNumber) / 100;
        }
    }
}

void WriteMatrix(double[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0;j<array.GetLength(1); j++)
        {
            Console.Write(array[i,j]+" ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}