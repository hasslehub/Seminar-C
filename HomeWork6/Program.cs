/* Задача 41
Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.
*/

Console.WriteLine();
Console.WriteLine("Задача 41");
Console.Write($"Введите желаемое количество чисел: ");
int M = Convert.ToInt32(Console.ReadLine());
int[] zadacha41 = new int[M];
FillArray(zadacha41);
PrintArray(zadacha41);
FindFromArray(zadacha41);

void PrintArray(int[] currentArray)
{
    Console.WriteLine("Вывод массива:");
    for (int i = 0; i < currentArray.Length; i++)
    {
        Console.Write($"{currentArray[i]} ");
    }
    Console.WriteLine();
}

void FillArray(int[] currentArray)
{
    for (int i = 0; i < currentArray.Length; i++)
    {
        Console.Write($"Введите {i + 1} число: ");
        zadacha41[i] = Convert.ToInt32(Console.ReadLine());
    }
}

void FindFromArray(int[] currentArray)
{
    int count = 0;
    for (int i = 0; i < currentArray.Length; i++)
    {
        if (currentArray[i] > 0)
        {
            count++;
        }
    }
    Console.Write($"Кол-во чисел > 0 : {count}");
    Console.WriteLine();
}



/* Задача 43
Напишите программу, которая найдёт точку пересечения двух прямых,
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; 5,5)
*/

Console.WriteLine();
Console.WriteLine("Задача 43");
double[,] zadacha43 = new double[2, 2];

InputValue(zadacha43);
PrintArrayDouble(zadacha43);
CrossPoint(zadacha43);

void PrintArrayDouble(double[,] currentArray)
{
    Console.WriteLine("Вывод массива:");
    for (int i = 0; i < currentArray.GetLength(0); i++)
    {
        for (int j = 0; j < currentArray.GetLength(1); j++)
        {
            Console.Write(currentArray[i, j] + "\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void InputValue(double[,] currentArray)
{
    for (int i = 0; i < currentArray.GetLength(0); i++)
    {
        Console.WriteLine($"Введите значения для {i + 1} уравнения: y = k1 * x + b1");

        for (int j = 0; j < currentArray.GetLength(1); j++)
        {
            if (i == 0 && j == 0)
            {
                Console.Write($"k1 = ");
                currentArray[i, j] = Convert.ToInt32(Console.ReadLine());
                //sum = sum + currentArrayInt[i, j];
            }

            else if (i == 0 && j == 1)
            {
                Console.Write($"b1 = ");
                currentArray[i, j] = Convert.ToInt32(Console.ReadLine());
            }

            else if (i == 1 && j == 0)
            {
                Console.Write($"k2 = ");
                currentArray[i, j] = Convert.ToInt32(Console.ReadLine());
            }

            else
            {
                Console.Write($"b2 = ");
                currentArray[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }
        Console.WriteLine(); ;
    }
    Console.WriteLine();
}

void CrossPoint(double[,] currentArray)
{
    double y, x;
    if (currentArray[0, 0] == currentArray[1, 0] && currentArray[0, 1] == currentArray[1, 1])
    {
        Console.WriteLine("Прямые совпадают");
    }

    else if (currentArray[0, 0] == currentArray[1, 0] && currentArray[0, 1] != currentArray[1, 1])
    {
        Console.WriteLine("Прямые параллельны");
    }

    else
    {
        // x = (b2 - b1) / (k1 - k2);
        x = (currentArray[1, 1] - currentArray[0, 1]) / (currentArray[0, 0] - currentArray[1, 0]);
        // y = k1 * x + b1
        y = currentArray[0, 0] * x + currentArray[0, 1];
        Console.WriteLine($"Точка пересечения прямых ({x}, {y})");
    }
    Console.WriteLine();
}


/////////////////////////////////////
/* 
Задача 1. 
Написать перевод десятичного числа в двоичное, используя рекурсию.
*/
Console.WriteLine();
Console.WriteLine("Задача 1*");
Console.Write("Введите десятичное число -> ");
int value = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"{value} = {DecToBin(value)}");
Console.WriteLine();

int DecToBin(int decValue)
{
    if (decValue == 0)
        return 0;
    else
        return (decValue % 2 + 10 * DecToBin(decValue / 2));
}



/*
Задача 2. 
На вход подаётся поговорка “без труда не выловишь и рыбку из пруда”. 
Используя рекурсию, подсчитайте, сколько в поговорке гласных букв.
*/
// НЕ ПОЛУЧИЛОСЬ
Console.WriteLine();
Console.WriteLine("Задача 2*");
string text = "без труда не выловишь и рыбку из пруда";//string.Empty;
//text = "без труда не выловишь и рыбку из пруда";
char[] letters = new char[] { 'а', 'е', 'ё', 'и', 'о', 'у', 'ы', 'э', 'ю', 'я'};
 // 'А', 'Е', 'Ё', 'И', 'О', 'У', 'Ы', 'Э', 'Ю', 'Я' };
Console.WriteLine();
int count = 0;
//Search(text, letters);

/*  
for (int i = 0; i < text.Length; i++)
{
    for (int j = 0; j < glasnie.Length; j++)
    {
        if (glasnie[j] == text[i]) { count++; }
    }
}
Console.WriteLine(count);
*/
/*
int Search(string currentAray, char[] alphabet, int i, int j)
{
    count = 0;
    if (i >= currentAray.Length
         j >= alphabet.Length)
        return 0;

    if (currentAray[i] == alphabet[j])
    {
        count++;
        Console.WriteLine($"{count}");
    }
    //
    Search(text, glasnie, i + 1, j);
    Search(text, glasnie, i, j + 1);

    Console.WriteLine($"{count} {currentAray[i]}  {alphabet[j]}");
    return count;
    //
}




/*
Задача 3. 
Дано число N. 
Используя только операцию деления и рекурсию, 
определите, что оно является степенью числа 3.
*/