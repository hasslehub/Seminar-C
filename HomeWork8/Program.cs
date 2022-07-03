void FillRandomArrayDouble(double[,] currentArray)
{
    Random rand = new Random();
    for (int i = 0; i < currentArray.GetLength(0); i++)
    {
        for (int j = 0; j < currentArray.GetLength(1); j++)
        {
            currentArray[i, j] = Math.Round((rand.NextDouble() * 10 - 5), 2);
        }
    }
}

void PrintArrayDouble(double[,] currentArray)
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



void FillArrayInt(int[,] currentArray)
{
    int num = 1;
    for (int i = 0; i < currentArray.GetLength(0); i++)
    {
        for (int j = 0; j < currentArray.GetLength(1); j++)
        {
            currentArray[i, j] = num++;
        }
    }
}

void FillRandomArrayInt(int[,] currentArray, int min, int max)
{
    Random rand = new Random();
    for (int i = 0; i < currentArray.GetLength(0); i++)
    {
        for (int j = 0; j < currentArray.GetLength(1); j++)
        {
            currentArray[i, j] = rand.Next(min, max);
        }
    }
}

void PrintArrayInt(int[,] currentArray)
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




/*
Задача 54
Задайте двумерный массив. 
Напишите программу, которая упорядочит по убыванию 
элементы каждой строки двумерного массива.
*/
void Zadacha54()
{
    Console.WriteLine();
    Console.WriteLine("Задача 54");
    Random rand = new Random();
    int rows = rand.Next(4, 8);
    int columns = rand.Next(4, 8);

    int[,] array54 = new int[rows, columns];

    FillRandomArrayInt(array54, -9, 10);
    PrintArrayInt(array54);
    ResetArray(array54);
    PrintArrayInt(array54);
}

void ResetArray(int[,] currentArray)
{
    int temp;

    for (int i = 0; i < currentArray.GetLength(0); i++)
    {
        for (int j = 0; j < currentArray.GetLength(1); j++)
        {
            for (int k = 0; k < currentArray.GetLength(1) - 1; k++)
            {
                if (currentArray[i, k] < currentArray[i, k + 1])
                {
                    temp = currentArray[i, k];
                    currentArray[i, k] = currentArray[i, k + 1];
                    currentArray[i, k + 1] = temp;
                }
            }
        }
    }
    Console.WriteLine();
}

Zadacha54();

/*
Задача 56
Задайте прямоугольный двумерный массив. 
Напишите программу, которая будет 
находить строку с наименьшей суммой элементов.
*/

void Zadacha56()
{
    Console.WriteLine();
    Console.WriteLine("Задача 56");
    Random rand = new Random();
    int rows = rand.Next(4, 8);
    int columns = rand.Next(4, 8);

    int[,] array56 = new int[rows, columns];

    FillRandomArrayInt(array56, -9, 10);
    PrintArrayInt(array56);
    Console.WriteLine();
    MinSum(array56);
}

void MinSum(int[,] currentArray)
{
    int sum = 0;
    int temp = 0;
    int rowIndex = 0;
    for (int j = 0; j < currentArray.GetLength(1); j++)
    {
        sum += currentArray[0, j];
    }

    for (int i = 0; i < currentArray.GetLength(0); i++)
    {
        for (int j = 0; j < currentArray.GetLength(1); j++)
        {
            temp += currentArray[i, j];
        }
        if (temp < sum)
        {
            sum = temp;
            rowIndex = i;
        }
        Console.WriteLine($"Строка -> {i} сумма элементов = {temp}");
        temp = 0;
    }
    Console.WriteLine();
    Console.Write($"Строка с наименьшей суммой элементов -> {rowIndex}");
    Console.WriteLine("  sum = " + sum);
}

Zadacha56();


/*
Задача 58
Заполните спирально массив 4 на 4 числами от 1 до 16.
*/

void Zadacha58()
{
    Console.WriteLine();
    Console.WriteLine("Задача 58");

    int[,] array58 = new int[4, 4];

    Console.WriteLine();
    FillCircleArrayInt(array58);
    PrintArrayInt(array58);

}
void FillCircleArrayInt(int[,] currentArray)
{

    int num = 1;
    int i = 0;
    int j = 0;

    for (j = 0; j < currentArray.GetLength(1); j++)
    {
        currentArray[i, j] = num++;
    }

    for (i = i + 1; i < currentArray.GetLength(0); i++)
    {
        currentArray[i, j - 1] = num;
        num++;
    }

    for (j = j - 2; j >= 0; j--)
    {
        currentArray[i - 1, j] = num;
        num++;
    }

    for (i = i - 2; i > 0; i--)
    {
        currentArray[i, j + 1] = num;
        num++;
    }

    for (j = 1; j < currentArray.GetLength(0) - 1; j++)
    {
        currentArray[i + 1 , j] = num;
        num++;
    }

    for (j = j - 1; j > 0 ; j--)
    {
        currentArray[i + 2 , j] = num;
        num++;
    }


}

Zadacha58();
/*
int n = 4;
int[,] sqareMatrix = new int[n, n];

int temp = 1;
int i = 0;
int j = 0;
/*
while (temp <= sqareMatrix.GetLength(0) * sqareMatrix.GetLength(1))
{
    sqareMatrix[i, j] = temp;
    temp++;
    if (i <= j + 1 && i + j < sqareMatrix.GetLength(1) - 1)
        j++;

    else if (i < j && i + j >= sqareMatrix.GetLength(0) - 1)
        i++;

    else if (i >= j && i + j > sqareMatrix.GetLength(1) - 1)
        j--;

    else
        i--;
}

WriteArray(sqareMatrix);

void WriteArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] / 10 <= 0)
                Console.Write($" {array[i, j]} ");

            else Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}
*/
