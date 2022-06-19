/*Задача 25: 
Напишите цикл, который принимает на вход два натуральных числа (A и B) 
и возводит число A в степень B.
3, 5 -> 243
2, 4 -> 16
*/

Console.WriteLine();
Console.WriteLine("Задача 25");
Console.Write("Введите натуральное число A: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите натуральное число B: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"{a} в степени {b} = {Power(a, b)}");
int Power(int x, int y)
{
    int pow = 1;
    for (int i = 1; i <= y; i++)
    {
        pow = pow * x;
    }
    return pow;
}



/*Задача 27: Напишите программу, которая принимает на вход число 
и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/

Console.WriteLine();
Console.WriteLine("Задача 27");
Console.Write("Введите число: ");
int c = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Cуммa цифр в числе {c} -> {Sum(c)}");
int Sum(int x)
{
    int res = 0;
    while (x > 0) 
    {
        res = res + x % 10;
        x = x / 10;
    }
    return res;
}


/*Задача 29: Напишите программу, которая задаёт 
массив из 8 случайных целых чисел и выводит отсортированный по модулю массив.
-2, 1, 7, 5, 19 -> [1, -2, 5, 7, 19]
6, 1, -33 -> [1, 6, -33]
*/

Console.WriteLine();
Console.WriteLine("Задача 29");
Console.Write("Введите желаемую длину массива: ");
int k = Convert.ToInt32(Console.ReadLine());
Random rand = new Random();
int[] array = new int[k];
void SetArray(int[] arr)
{
    int len = arr.Length;
    for (int i = 0; i < len; i++)
    {
        arr[i] = rand.Next(-9, 9);
    }
}

void PrintArray(int[] arr, string note)
{
    int len = arr.Length;
    Console.Write($"{note}: ");
    for (int i = 0; i < len; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}

void SortArray(int[] arr)
{
    int len = arr.Length;
    for (int i = 0; i < len; i++)
        for (int j = 0; j < len - i - 1; j++)
        {
            if (Math.Abs(arr[j]) > Math.Abs(arr[j + 1]))
            {
                int temp = arr[j];
                arr[j] = arr[j + 1];
                arr[j + 1] = temp;
            }
        }
}

SetArray(array);
PrintArray(array, "Ваш случайный массив");
SortArray(array);
PrintArray(array, "Ваш отсортированный массив по модулю");


/* Дополнительные задачи.
Знакомство с языками программирования. Семинар 4.


Задача 1.
На вход подаётся натуральное десятичное число. 
Проверьте, является ли оно палиндромом в двоичной записи.
*/

Console.WriteLine();
Console.WriteLine("Задача 1");
Console.Write("Введите натуральное десятичное число: ");
int d = Convert.ToInt32(Console.ReadLine());
void DecToBin(int a)
{
    int res = 0;
    int i = 0;
    int j = 0;
    int[] temp = new int[33]; // массив для временного хранения значения
    Console.Write($"{a} -> ");

    for (i = 0; a >= 1; i++)
    {
        res = a % 2;
        temp[i] = res;
        a = a / 2;
    }
    if (i < 2) { temp[2] = 0; j = 2; i = 2; }
    j = i;
    int[] bin = new int[j];
    int len = bin.Length;  // массив с конечным результатом

    for (j = 0; j < len; j++)
    {
        i--;
        bin[j] = temp[i];
        Console.Write($"{bin[j]} ");
    }
    Console.WriteLine();
    Polyndrom(bin);
}
DecToBin(d);
void Polyndrom(int[] arrtest)
{
    int len = arrtest.Length;
    int count = 0;
    int var = len / 2;

    Console.WriteLine("-------------------------");

    for (int i = 0; i < var; i++)
    {
        if (arrtest[i] == arrtest[len - 1])
        {
            Console.WriteLine($"{arrtest[i]} == {arrtest[len - 1]}");
            len--;
            count++;
        }
        else Console.WriteLine($"{arrtest[i]} != {arrtest[len - 1]}");
    }

    if (count == var) Console.WriteLine("Ура, число является палиндромом в двоичной записи");
    else Console.WriteLine("Число неявляется палиндромом в двоичной записи");

}


/* Задача 2. 
Напишите метод, который заполняет массив случайным количеством 
(от 1 до 100) нулей и единиц. Размер массива должен 
совпадать с квадратом количества единиц в нём.
*/

Console.WriteLine();
Console.WriteLine("Задача 2");
Console.Write("Введите кол-во единиц в массиве: ");
int e = Convert.ToInt32(Console.ReadLine());
Random rand1 = new Random();
Console.WriteLine($"Размер массива -> {e*e}");
int[] array2 = new int[e*e];
void SetArray2(int[] arr)
{
    int len = arr.Length;
    int i = 0;
    int col1 = 0;
    int col0 = 0;
    int pow = 0;
    for (i = 0; i < len; i++)
    {
        arr[i] = rand1.Next(0, 2);
        if (arr[i] == 1)
        {
            col1++;
            pow = col1 * col1;

            if (col1 > d)
            {
                arr[i] = 0;
                col0++;
            }
        }
        else
        {
            col0++;
        }
        Console.Write(arr[i]);
    }
    Console.WriteLine();
    Console.Write($"Кол-во 1 -> {len - col0}  ");
    Console.Write($"Кол-во 0 -> {col0}  ");
}
SetArray2(array2);
Console.WriteLine();

/* Задача 3. Массив на 100 элементов задаётся случайными числами от 1 до 99. 
Определите самый часто встречающийся элемент в массиве. 
Если таких элементов несколько, вывести их все.
*/

Console.WriteLine();
Console.WriteLine("Задача 3");
Console.WriteLine("Здесь чего-то не хватает :(");
int[] array3 = new int[10];
int res = 0;
int max = 0;
void SetNewArray(int[] currentArray)
{
    Random rand = new Random();
    for (int i = 0; i < currentArray.Length; i++)
    {
        currentArray[i] = rand.Next(1, 9);
    }
}

void PrintArray3(int[] currentArray)
{
    Console.WriteLine();
    Console.WriteLine("Вывод массива:");
    for (int i = 0; i < currentArray.Length; i++)
    {
        Console.Write($"{currentArray[i]} ");
    }
    Console.WriteLine();
}

void FindInArray(int[] currentArray, int index)
{
    int match = currentArray[index];
    int col = 0;
    max = 0;
    res = 0;
    for (int i = 0; i < currentArray.Length; i++)
    {
        if (currentArray[i] == match)
        {
            col++;

            if (col > max)
            {
                max = col;
                res = currentArray[i];
            }
        }
    }
}

SetNewArray(array3);
PrintArray3(array3);

for (int i = 0; i < array3.Length; i++)
{
    FindInArray(array3, i);
    Console.Write($"{res} встречается ");
    Console.WriteLine($"{max} раз ");
}
