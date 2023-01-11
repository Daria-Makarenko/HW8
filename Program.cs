// Домашняя работа № 8

// Задача 1 - Задайте двумерный массив. Напишите программу,
// которая упорядочит по убыванию элементы каждой строки двумерного массива.
/*
int [,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] array = new int[rows, columns];

    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++)
        {
            array[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return array;
}

Console.Write("Input a number of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max value: ");
int max = Convert.ToInt32(Console.ReadLine());

void Show2dArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");

        Console.WriteLine();
    }
    Console.WriteLine();
}

void DescendingArray(int [,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1) - 1; j++)
        {
            int maxPosition = array[i, j];
            for(int k = j + 1; k < array.GetLength(1); k++)
            {
                if(array[i, k] > array[i, j])
                {
                maxPosition = array [i, k];
                int temp = array[i, j];
                array [i, j] = array[i, k];
                array[i, k] = temp;
                }
            }
        }
    }
}

int [,] myArray = CreateRandom2dArray(rows, columns, min, max);
Show2dArray(myArray);

DescendingArray(myArray);
Show2dArray(myArray);
*/

// Задача 2 - Задайте прямоугольный двумерный массив. Напишите программу, 
//которая будет находить строку с наименьшей суммой элементов.
/*
int [,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] array = new int[rows, columns];
    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++)
        {
            array[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return array;
}

Console.Write("Input a number of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max value: ");
int max = Convert.ToInt32(Console.ReadLine());

void Show2dArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");
             Console.WriteLine();
    }
    Console.WriteLine();
}


int SumMinArray(int [,] array)
{
    int MinSum = 0;
    int Sum1 = 0;
    int minRows = 0;
    for(int i = 0; i < array.GetLength(0); i++)
    {
        int Sum2 = 0;
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Sum2 += array[i, j];
        }
            if( Sum2 < Sum1)
            {
               MinSum = Sum2;
               minRows = i;
            }
            Sum1 = Sum2;
    }
    return minRows;
}

int [,] myArray = CreateRandom2dArray(rows, columns, min, max);
Show2dArray(myArray);

int result = SumMinArray(myArray);
Console.WriteLine ($"Строка с наименьшей суммой элементов -> {result}");
*/

// Задача 3 - Задайте две матрицы. Напишите программу, 
//которая будет находить произведение двух матриц.
/*
int [,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] array = new int[rows, columns];
    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++)
        {
            array[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return array;
}

Console.Write("Input a number of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max value: ");
int max = Convert.ToInt32(Console.ReadLine());

int [,] CreateRandom2dArray2(int rows2, int columns2, int minValue2, int maxValue2)
{
    int[,] array = new int[rows2, columns2];
    for(int i = 0; i < rows2; i++)
    {
        for(int j = 0; j < columns2; j++)
        {
            array[i, j] = new Random().Next(minValue2, maxValue2 + 1);
        }
    }
    return array;
}

Console.Write("Input a number of rows: ");
int rows2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of columns: ");
int columns2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min value: ");
int min2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max value: ");
int max2 = Convert.ToInt32(Console.ReadLine());

void Show2dArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");
             Console.WriteLine();
    }
    Console.WriteLine();
}

int [,] MatrixMulti(int [,] MatrixA, int [,] MatrixB)
{
    if(columns != rows2)
    {
        Console.WriteLine("Умножение невозможно!");
    }
    int[,] cArray = new int[MatrixA.GetLength(0), MatrixB.GetLength(1)];

    for(int i = 0; i < MatrixA.GetLength(0); i++)
    {
        for(int j = 0; j < MatrixB.GetLength(0); j++)
        {
            for(int k = 0; k < MatrixB.GetLength(1); k++)
            {
                cArray[i,k] += MatrixA[i,j] * MatrixB[j,k];
            }
        }
    }
    return cArray;
}

int [,] myArray = CreateRandom2dArray(rows, columns, min, max);
Show2dArray(myArray);
int [,] myArray2 = CreateRandom2dArray2(rows2, columns2, min2, max2);
Show2dArray(myArray2);

int [,] Matrix = MatrixMulti(myArray, myArray2);
Show2dArray(Matrix);
*/

// Задача 4 - Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
//Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
/*
int [,,] CreateRandom3dArray(int rows, int columns, int klad)
{
    int[,,] array = new int[rows, columns,klad];
    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++)
        {
            for(int k = 0; k < klad; k++)
            {
                array[i, j, k] = new Random().Next(10, 100);
                if(array[i,j,k] == array [i,j,k])
                {
                    array[i, j, k] = new Random().Next(10, 100);
                }
            }
        }
    }

    return array;
}

Console.Write("Input a number of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of klad: ");
int klad = Convert.ToInt32(Console.ReadLine());


void Show3dArray(int[,,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            for(int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write(array[i,j,k] + " ");
                Console.Write($"({i},{j},{k}) ");
            }
               Console.WriteLine();
        }
    }
    Console.WriteLine();
}

int [,,] myArray = CreateRandom3dArray(rows, columns, klad);
Show3dArray(myArray);
*/


