/* Задача 34: 
Задайте массив заполненный случайными положительными
трёхзначными числами. Напишите программу, которая 
покажет количество чётных чисел в массиве.
 [345, 897, 568, 234] -> 2
*/

Console.WriteLine();
Console.WriteLine("Задача 34");
Console.Write("Задайте размер массива: ");
int a = Convert.ToInt32(Console.ReadLine());
int[] zadacha34 = new int[a];
void NewRandomArray(int[] currentArray)
{
    Random rand = new Random();
    for (int i = 0; i < currentArray.Length; i++)
    {
        currentArray[i] = rand.Next(100, 1000);
    }
}
void PrintArray(int[] currentArray)
{
    Console.WriteLine("Вывод массива:");
    for (int i = 0; i < currentArray.Length; i++)
    {
        Console.Write($"{currentArray[i]} ");
    }
    Console.WriteLine();
}
void Chet(int[] currentArray)
{
    int len = currentArray.Length;
    int col = 0;
    for (int i = 0; i < len; i++)
    {
        if (currentArray[i] % 2 == 0)
            col++;
    }
    Console.WriteLine($"Количество чётных чисел в массиве -> {col}");
}

NewRandomArray(zadacha34);
PrintArray(zadacha34);
Chet(zadacha34);




/* Задача 36: 
Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
 [3, 7, 23, 12] -> 19
 [-4, -6, 89, 6] -> 0
*/


Console.WriteLine();
Console.WriteLine("Задача 36");
Console.Write("Задайте размер массива: ");
int b = Convert.ToInt32(Console.ReadLine());
int[] zadacha36 = new int[b];
void NewRandomArray1(int[] currentArray)
{
    Random rand = new Random();
    for (int i = 0; i < currentArray.Length; i++)
    {
        currentArray[i] = rand.Next(-100, 100);
    }
}
void FindFromArray(int[] currentArray)
{
    int sum = 0;
    for (int i = 0; i < currentArray.Length; i++)
    {
        if (i % 2 > 0)
            sum = sum + currentArray[i];
    }
    Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях -> {sum}");
}

NewRandomArray1(zadacha36);
PrintArray(zadacha36);
FindFromArray(zadacha36);


/*Задача 38: 
Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76
*/

Console.WriteLine();
Console.WriteLine("Задача 36");
Console.Write("Задайте размер массива: ");
int c = Convert.ToInt32(Console.ReadLine());
double[] zadacha38 = new double[c];
void NewRandomArray2(double[] currentArray)
{
    Random rand = new Random();
    for (int i = 0; i < currentArray.Length; i++)
    {
        currentArray[i] = rand.NextDouble() + rand.Next(0, 100);
    }
}
void FindFromArray1(double[] currentArray)
{
    double max = currentArray[0];
    double min = currentArray[0];
    double sum = 0;
    for (int i = 0; i < currentArray.Length; i++)
    {
        if (currentArray[i] > max)
            max = currentArray[i];
        else if (currentArray[i] < min)
            min = currentArray[i];
    }
    Console.WriteLine($"Разница между максимальным и минимальным элементов массива -> {sum = max - min}");
}
void PrintArrayDouble(double[] currentArray)
{
    Console.WriteLine("Вывод массива:");
    for (int i = 0; i < currentArray.Length; i++)
    {
        Console.Write($"{currentArray[i]} ");
    }
    Console.WriteLine();
}

NewRandomArray2(zadacha38);
PrintArrayDouble(zadacha38);
FindFromArray1(zadacha38);


///////////////////////////////////////////

/*Задача 1. 
Задан массив из случайных цифр на 15 элементов. 
На вход подаётся трёхзначное натуральное число. 
Напишите программу, которая определяет, есть в массиве 
последовательность из трёх элементов, совпадающая с введённым числом.

{0, 5, 6, 2, 7, 7, 8, 1, 1, 9} - 277 -> да 
{4, 4, 3, 6, 7, 0, 8, 5, 1, 2) - 812 -> нет
*/

Console.WriteLine();
Console.WriteLine("Задача 1");
Console.Write("Введите трёхзначное натуральное число: ");
int d = Convert.ToInt32(Console.ReadLine());
int[] zadacha1 = new int[15];
//zadacha1[0] = 0;
//zadacha1[1] = 5;
//zadacha1[2] = 6;
//zadacha1[3] = 2;
//zadacha1[4] = 7;
//zadacha1[5] = 7;
//zadacha1[6] = 8;
//zadacha1[7] = 1;
//zadacha1[8] = 1;
//zadacha1[9] = 9;
void NewRandomArray3(int[] currentArray)
{
    Random rand = new Random();
    for (int i = 0; i < currentArray.Length; i++)
    {
        currentArray[i] = rand.Next(0, 10);
    }
}
void FindFromArray2(int[] currentArray)
{
    bool flag = false;
    int j = 0;

    for (int i = 0; i < currentArray.Length; i++)
    {
        if (currentArray[i] == (d / 100) % 10) //
        {
            j = i + 1;
            if (currentArray[j] == (d / 10) % 10)
            {
                j++;
                if (currentArray[j] == d % 10)
                {
                    flag = true;
                }
            }
        }
    }
    if (flag) Console.WriteLine($"В массиве есть последовательность {d}");
    else Console.WriteLine($"В массиве НЕТ последовательности {d}");
}
NewRandomArray3(zadacha1);
PrintArray(zadacha1);
FindFromArray2(zadacha1);

/*Задача 2. 
На вход подаются два числа случайной длины. 
Найдите произведение каждого разряда первого числа 
на каждый разряд второго. Ответ запишите в массив.

24, 132 -> {2, 6, 4, 4, 12, 8}
*/

Console.WriteLine();
Console.WriteLine("Задача 2");
Random rand = new Random();
int e = rand.Next(1, 1000);
int f = rand.Next(1, 1000);
int g = Len(e) + Len(f);

int Len(int a)
{
    int x = 0;
    while (a > 0)
    {
        a = a / 10;
        x++;
    }
    return x;
}
int[] zadacha2 = new int[g];
int[] zadacha21 = new int[Len(e)];
int[] zadacha22 = new int[Len(f)];
//viod Fil(int[] ar1, int a)
//{
    //int len = ar1.Length;
    while (e > 0)
    {
        e = a % 10;
        for (int i = 0; i < zadacha21.Length; i++)
        {
            zadacha21[zadacha21.Length - i-1] = a;
        }
        e = e / 10;
    }
//}
void Res(int[] currentarray, int m, int n)
{

}
Console.WriteLine($"Заданы два числа: {e}, {f}");
Console.WriteLine($"g = {g}");
//Fil(zadacha21, e);
PrintArray(zadacha21);


/* Задача 3. 
Найдите все числа от 1 до 1000000, сумма цифр которых 
в три раза меньше их произведений. Подсчитайте их количество.
*/