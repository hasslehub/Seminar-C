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
    if (d > 100 && d < 1000)
    {
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
    else Console.WriteLine($"Число {d} не трёхзначное ");
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
int e = rand.Next(1, 10000); // 1 число случайной длины
int f = rand.Next(1, 10000); // 2 число случайной длины
int g = Len(e) * Len(f);    // общая длина массива с результатом


int Len(int a)  // определяем длину массива для каждого числа
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
int[] temp1 = new int[Len(e)];  // массив для первого числа
int[] temp2 = new int[Len(f)];  // массив для второго числа
void Fil(int[] ar1, int a)      // переводим числа в массив
{
    int len = ar1.Length;
    int i = 0;
    while (a > 0)
    {
        int res = a;
        res = res % 10;
        if (i < len)
        {
            ar1[len - i - 1] = res;
        }
        a = a / 10;
        i++;
    }
}
void Res(int[] currentarray1, int[] currentarray2, int b) // перемножаем элементы массивов
{

    for (int i = 0; i < currentarray1.Length; i++)
    {
        for (int j = 0; j < currentarray2.Length; j++)
        {
            zadacha2[zadacha2.Length - b] = currentarray1[i] * currentarray2[j];
            b--;

        }
    }
}
Console.WriteLine($"Заданы два числа: {e}, {f}");
Console.WriteLine($"g = {g}");
Fil(temp1, e);
Fil(temp2, f);
PrintArray(temp1);
PrintArray(temp2);
Res(temp1, temp2, g);
PrintArray(zadacha2);




/* Задача 3. 
Найдите все числа от 1 до 1000000, сумма цифр которых 
в три раза меньше их произведений. Подсчитайте их количество.
*/


Console.WriteLine();
Console.WriteLine("Задача 2");


double res = 0;
double resSum = 0;
double resMulti = 1;
int j = 1;

for (int i = 0; i < 1000000; i++)
{
    int v = i + 1;
    int w = v;

    while (w > 0)
    {
        resSum = resSum + w % 10;
        resMulti = resMulti * (w % 10);
        w = w / 10;
    }
    if (resSum > 0) res = resMulti / resSum;

    if (res == 3)
    {
        Console.Write($"Кол-во = {j}  ");
        Console.Write($"число = {v} ");
        Console.Write($"Сумма цифр = {resSum}  ");
        Console.Write($"Произ-ние = {resMulti}  ");
        Console.WriteLine($"{resMulti}/{resSum} = {res}  ");
        j++;
    }

    resSum = 0;
    resMulti = 1;

}
Console.WriteLine();
Console.WriteLine($"Кол-во чисел, сумма цифр которых в три раза меньше их произведений = {j - 1}");
Console.WriteLine();
