//Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
//m = 3, n = 4.
//0,5 7 -2 -0,2
//1 -3,3 8 -9,9
//8 7,8 -7,1 9

// Пользователь вводит количество строк, столбцов, минимальное и максимальное значения массива

/*double [,] RandomRealNumbers(int row, int column, int minVal, int maxVal)
{
    double [,] randomArray = new double [row, column];
    for(int m = 0; m < row; m++)
        for(int n = 0; n < column; n++)
        {
            randomArray[m, n] = new Random().Next(minVal, maxVal + 1) + new Random().NextDouble();
            randomArray[m, n] = Math.Round(randomArray[m, n], 2);
        }
    return randomArray;        
}

void Show2dArray(double[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

Console.Write("Input count of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input count of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());

Console.Write("Input min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

double [,] new2dArray = RandomRealNumbers(rows, columns, min, max);
Show2dArray(new2dArray);
*/

// Пользователь вводит количество строк, столбцов

/*
double [,] RandomRealNumbers(int row, int column)
{
    double [,] randomArray = new double [row, column];
    for(int m = 0; m < row; m++)
        for(int n = 0; n < column; n++)
        {
            randomArray[m, n] = new Random().Next(-100, 100) + new Random().NextDouble();
            randomArray[m, n] = Math.Round(randomArray[m, n], 2);
        }
    return randomArray;        
}

void Show2dArray(double[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

Console.Write("Input count of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input count of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());

double [,] new2dArray = RandomRealNumbers(rows, columns);
Show2dArray(new2dArray);
*/


//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//17 -> такого числа в массиве нет

/*
int [,] CreateNewArray(int row, int column, int minVal, int maxVal)
{
    int [,] creatednewArray = new int[row, column];
    for(int i = 0; i < row; i++)
    {
        for(int j = 0; j < column; j++)
        {
            creatednewArray[i, j] = new Random().Next(minVal, maxVal + 1);
        }
    }
    return creatednewArray;
}

void ShowNewArray(int [,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {

            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

bool ElemArray(int elemArray, int [,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            if(elemArray == array[i, j])
            
                return true;
        }
    }
    return false;
}

Console.WriteLine("Input number of rows in the array: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number of columns in the array: ");
int columns = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input min value in the array: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input max value in the array: ");
int maxValue = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input any number: ");
int number = Convert.ToInt32(Console.ReadLine());

int [,] newArray = CreateNewArray(rows, columns, minValue, maxValue);
ShowNewArray(newArray);

bool res = ElemArray(number, newArray);
{   
    if(res == true)
        Console.WriteLine($"Number {number} is number of array.");
    else Console.WriteLine($"Number {number} is not number of array.");
}
*/


//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

/*
double [,] Create2dArray(int row, int column)
{
    double [,] created2dArray = new double [row, column];
    {
    for(int i = 0; i < row; i ++)
        for(int j = 0; j < column; j++)

            created2dArray[i, j] = new Random().Next(-10, 10);
    }
    return created2dArray;
}

void Show2dArray(double [,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }        
        Console.WriteLine();
    }
    Console.WriteLine();
}

double [] SumColumn(double[,] array, double [] ArraySum)
{
    for(int j = 0; j < array.GetLength(1); j++)
    {
        double sumColumn = 0;        
        for(int i = 0; i < array.GetLength(0); i++)
        {
            sumColumn = sumColumn + array[i, j];
        }
        ArraySum [j] = sumColumn;
             
    }
    return ArraySum; 
}

double [] AverageColumnArray (int row, double [] array)
{
    double [] averageColumn = new double[row];
    for(int i = 0; i < array.Length; i++)
        
        averageColumn [i] = array[i] / row;
           
    return averageColumn;
}

void ShowArray(double [] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
        Console.Write(array[i] + " ");
        
    Console.WriteLine();
}

Console.Write("Input count of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input count of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());

double [,] new2dArray = Create2dArray(rows, columns);
Show2dArray(new2dArray);

double [] sumArray = new double [columns];
double [] sumColumn = SumColumn(new2dArray, sumArray);

double [] averageColumn = AverageColumnArray(rows, sumArray);
ShowArray(averageColumn);
*/






