/* Задача 47 
Задайте двумерный массив размером m×n, 
заполненный случайными вещественными числами, 
округлёнными до одного знака.
m = 3, n = 4.
0,5   7   -2   -0,2
1   -3,3   8   -9,9
8    7,8  -7,1   9
*/

Console.WriteLine();
Console.WriteLine("Задача 47");
Random rand = new Random();
int rows = 3;
int column = 4;
double[,] arrayDouble = new double[rows, column];

void FillArrayDouble(double[,] currentArray)
{
    for (int i = 0; i < currentArray.GetLength(0); i++)
    {
        for (int j = 0; j < currentArray.GetLength(1); j++)
        {
            currentArray[i, j] = Math.Round((rand.NextDouble() + rand.Next(-10, 10)), 1);
        }
    }
}

void PintArrayDouble(double[,] currentArray)
{
    for (int i = 0; i < currentArray.GetLength(0); i++)
    {
        for (int j = 0; j < currentArray.GetLength(1); j++)
        {
            Console.Write(currentArray[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

FillArrayDouble(arrayDouble);
PintArrayDouble(arrayDouble);
Console.WriteLine();



/* Задача 50 
Напишите программу, которая на вход принимает 
позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, 
что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4

[1, 3] -> 3
*/

Console.WriteLine();
Console.WriteLine("Задача 50");
int[,] zadacha50 = new int[rows, column];
FillArrayInt(zadacha50);
PintArrayInt(zadacha50);
Console.WriteLine("Введите позиции элемента в двумерном массиве");
Console.Write("Позиция строки: ");
int rowsFind = Convert.ToInt32(Console.ReadLine());
Console.Write("Позиция столбца: ");
int columnFind = Convert.ToInt32(Console.ReadLine());
MatchIndex(zadacha50, rowsFind, columnFind);

void FillArrayInt(int[,] currentArrayInt)
{
    for (int i = 0; i < currentArrayInt.GetLength(0); i++)
    {
        for (int j = 0; j < currentArrayInt.GetLength(1); j++)
        {
            currentArrayInt[i, j] = rand.Next(-10, 10);
        }
    }
}

void PintArrayInt(int[,] currentArrayInt)
{
    for (int i = 0; i < currentArrayInt.GetLength(0); i++)
    {
        for (int j = 0; j < currentArrayInt.GetLength(1); j++)
        {
            Console.Write(currentArrayInt[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

void MatchIndex(int[,] currentArrayInt, int rowIndex, int columnIndex)
{
    bool find = false;
    if (rowsFind < currentArrayInt.GetLength(0) && columnFind < currentArrayInt.GetLength(1))
    {
        for (int i = 0; i < currentArrayInt.GetLength(0); i++)
        {
            for (int j = 0; j < currentArrayInt.GetLength(1); j++)
            {
                if (currentArrayInt[i, j] == currentArrayInt[rowsFind, columnFind])
                {
                    find = true;
                }
            }
        }
    }
    if (find) Console.WriteLine($"Значение искомого элемента -> {currentArrayInt[rowsFind, columnFind]} ");
    else Console.WriteLine($"Значение искомого элемента не существует! ");
}


/*Задача 52
Задайте двумерный массив из целых чисел. 
Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 5 3
8 4 6 4

Среднее арифметическое каждого столбца: 4,6; 5,6; 6; 3.
*/

Console.WriteLine();
Console.WriteLine("Задача 52");
int[,] zadacha52 = new int[rows, column];
FillArrayInt(zadacha52);
PintArrayInt(zadacha52);
FindArrayMidSum(zadacha52);
Console.WriteLine();

void PrintArr(double[] currentArray)
{
    for (int i = 0; i < currentArray.Length; i++)
    {
        Console.Write($"{currentArray[i]}" + "\t");
    }
}

void FindArrayMidSum(int[,] currentArrayInt)
{
    double sum = 0.00;
    double res = 0.00;
    double[] eachColumn = new double[column];
    for (int j = 0; j < currentArrayInt.GetLength(1); j++)
    {
        for (int i = 0; i < currentArrayInt.GetLength(0); i++)
        {
            sum = sum + currentArrayInt[i, j];
        }
        //Console.WriteLine($"Сумма {j} столбца = {sum} ");
        res = (sum / currentArrayInt.GetLength(0));
        eachColumn[j] = Math.Round(res, 2);
        res = 0.00;
        sum = 0.00;

    }

    Console.Write("Среднее арифметическое каждого столбца: ");

    PrintArr(eachColumn);
}
