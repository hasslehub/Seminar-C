/* Задача 19 
Напишите программу, которая принимает на вход пятизначное число 
и проверяет, является ли оно палиндромом.
14212 -> нет
23432 -> да
12821 -> да
*/

Console.WriteLine();
Console.WriteLine("Задача 19");
Console.WriteLine("Введите пятизначное число");
int a = Convert.ToInt32(Console.ReadLine());


if (a > 9999 && a < 100000)
{
   int simbol1 = a / 10000;
   int simbol2 = a % 10000 / 1000;
   //int simbol3 = a % 1000 / 100;
   int simbol4 = a % 100 / 10;
   int simbol5 = a % 10;

 if (simbol1 == simbol5 && simbol2 == simbol4)
    {
        Console.WriteLine($"Веденное число {a}  является палиндромом");
    }
    else
    {
        Console.WriteLine($"Веденное число {a}  не является палиндромом");
    }
}
else
{
    Console.WriteLine("Ошибка ввода!");
}

/*Задача 21 
Напишите программу, которая принимает на вход координаты 
двух точек и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/

Console.WriteLine();
Console.WriteLine("Задача 21");
Console.WriteLine("Введите координаты двух точек в 3D пространстве");
Console.WriteLine("Первая точка");
Console.Write("x: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("y: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("z: ");
int z1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Вторая точка");
Console.Write("x: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("y: ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("z: ");
int z2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Координаты A ({x1},{y1},{z1})");
Console.WriteLine($"Координаты B ({x2},{y2},{z2})");

Console.Write($"Расстояние между точками A и B равно: ");
Console.WriteLine(Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2)));


/*Задача 23
Напишите программу, которая принимает на вход число (N) 
и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27.
5 -> 1, 8, 27, 64, 125
*/

Console.WriteLine();
Console.WriteLine("Задача 23");
Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
int count = 1;
while (count <= N)
{
    Console.WriteLine($"{count} -> {Math.Pow(count, 3)}");
    count++;
}
Console.WriteLine();


///////////////////////////
///////////////////////////

// Дополнительные задачи
/* Задача 1. 
Рассчитать значение y при заданном x по формуле:
y=sin^2 x  при х>0       (sin^2 x = (1-cos 2x)/2)
y=1-2sin x^2 при х <=0
*/

Console.WriteLine();
Console.WriteLine("Задача 1*");
Console.Write("Введите x: ");
double X = Convert.ToDouble(Console.ReadLine());
double radianX = Math.PI * X / 180.0; // перевод в радиан

if (X > 0)
{
    Console.WriteLine("x>0 -> y = sin^2 x = (1-cos 2x)/2");
    Console.WriteLine($"y = {((1 - Math.Cos(2 * radianX))/2)}");
}
else
{
    Console.WriteLine("x<=0 -> y=1-2sin x^2");
    Console.WriteLine($"y = {(1 - 2 * (Math.Sin(radianX)))}"); // если значение radianX в степени 2, результат отличается от калькулятора
}

/*Задача 2
Дано трёх значное число N. Определить кратна ли трём сумма всех
его цифр.
*/

Console.WriteLine();
Console.WriteLine("Задача 2*");
Console.WriteLine("Введите трёх значное число");
int b = Convert.ToInt32(Console.ReadLine());

if (b > 99 && b < 1000)
{
    int b1 = b / 100;
    int b2 = b % 100 / 10;
    int b3 = b % 10;
    if ((b1 + b2 + b3) % 3 == 0)
    {
        Console.WriteLine($"В вашем числе {b} сумма всех его цифр кратна трём");
    }
    else
    {
        Console.WriteLine($"В вашем числе {b} сумма всех его цифр не кратна трём");
    }
}
else
{
    Console.WriteLine("Ошибка ввода!");
}

/*Задача 3
Дано трёх значное число N. Определить, есть ли среди его
цифры 4 или 7.
*/

Console.WriteLine();
Console.WriteLine("Задача 3*");
Console.WriteLine("Введите трёх значное число");
int с = Convert.ToInt32(Console.ReadLine());

if (с > 99 && с < 1000)
{
    int с1 = с / 100;
    int с2 = с % 100 / 10;
    int с3 = с % 10;

    if (с1 == 4 || с2 == 4 || с3 == 4)
    {
        if (с1 == 7 || с2 == 7 || с3 == 7)
        {
            Console.WriteLine($"В вашем числе {с} есть цифра 4 и 7");
        }
        // Если оба условия выполнятся выводится 2 сообщения
        Console.WriteLine($"В вашем числе {с} есть цифра 4");
    }

    else if (с1 == 7 || с2 == 7 || с3 == 7)
    {
        Console.WriteLine($"В вашем числе {с} есть цифра 7");
    }

    else
    {
        Console.WriteLine($"В вашем числе {с} нет цифр 4 и 7");
    }
}
else
{
    Console.WriteLine("Ошибка ввода!");
}

/* Задача 4
Дан массив длиной 10 элементов. 
Заполнить его числами от 1 до 10.
*/

Console.WriteLine();
Console.WriteLine("Задача 4*");
Console.WriteLine("Заполнить массив длиной 10 элементов числами от 1 до 10");
int[] array = new int[10];
int length = array.Length;
int i;
Random rand = new Random();
for (i = 0; i < length; i++)
{
    array[i] = rand.Next(1, 11);
    Console.Write($"{array[i]} ");
}

Console.WriteLine();


/* Задачи повышенной сложности:
Задача 1. 
На ввод подаётся номер четверти. Создаются 3 случайные точки в этой четверти. 
Определите самый оптимальный маршрут для торгового менеджера, 
который выезжает из центра координат.
*/
Console.WriteLine();
Console.WriteLine("Задача 1**");
void GetPoint(int[] point)
{
    int len = point.Length;
    int index;
    for (index = 0; index < len; index++)
    {
        point[index] = new Random().Next(1, 10);
    }
}
void PrintPoint(int[] data, string note)
{
    int len = data.Length;
    Console.WriteLine($"Координаты точки {note} ({data[0]}, {data[1]})");
}
double Calculator(int[] input1, int[] input2)
{
    double res = Math.Sqrt(Math.Pow(input1[0] - input2[0], 2) + Math.Pow(input1[1] - input2[1], 2));
    return res;
}

void minRoute(double[] arrayPoint) // // min значение + индекс min значения
{
    int len = arrayPoint.Length;
    int index = 0;
    double min = arrayPoint[index];
    int tPoint = 0;
    string go0 = "к точке A";
    string go1 = "к точке B";
    string go2 = "к точке C";

    while (index < len)
    {

        if (arrayPoint[index] < min)
        {
            min = arrayPoint[index]; // min значение          
        }


        if (arrayPoint[index] == min)  // индекс min значения
        {
            tPoint = index;      // точка маршрута
        }

        index++;
    }
    if (tPoint == 0) {Console.WriteLine($"Начало движения {go0} -> {min} ");}
    else if (tPoint == 1) {Console.WriteLine($"Начало движения {go1} -> {min} ");}
    else if (tPoint == 2) {Console.WriteLine($"Начало движения {go2} -> {min} ");}
}

void nextPoint(double[] arrayPoint) // mid значение + индекс mid значения
{
    int len = arrayPoint.Length;
    int index = 0;
    double min = arrayPoint[index];
    double max = arrayPoint[index];
    double mid = arrayPoint[index];
    int tPoint = 0;
    int tPointMid = 0;
    string go0 = "AB (BA)";
    string go1 = "AC (CA)";
    string go2 = "BC (CB)";
    

    for (index = 0; index < len; index++)
    {
        if (arrayPoint[index] < min)
        {
            min = arrayPoint[index]; // min значение          
        }

        if (arrayPoint[index] > max)
        {
            max = arrayPoint[index]; // max значение          
        }

    }

    for (index = 0; index < len; index++)
    {
        if (arrayPoint[index] > min && arrayPoint[index] < max)
        {
            mid = arrayPoint[index]; // mid значение          
        }

        if (arrayPoint[index] == mid)  // индекс min значения
        {
            tPointMid = index;      // точка маршрута
        }

        if (arrayPoint[index] == min)  // индекс min значения
        {
            tPoint = index;      // точка маршрута
        }


    }
    
    if (tPoint == 0) {Console.WriteLine($"Далее {go0} ");}
    else if (tPoint == 1) {Console.WriteLine($"Далее {go1} ");}
    else if (tPoint == 2) {Console.WriteLine($"Далее {go2} ");}
    if (tPointMid == 0) {Console.WriteLine($"Далее {go0} ");}
    else if (tPointMid == 1) {Console.WriteLine($"Далее {go1} ");}
    if (tPointMid == 2) {Console.WriteLine($"Далее {go2} ");}
}

int[] startPoint = new int[2] { 0, 0 };
int[] pointA = new int[2];
int[] pointB = new int[2];
int[] pointC = new int[2];

double[] startRoute = new double[3]; // массив всех возможных начальных маршрутов
double[] nextRoute = new double[3]; // массив всех возможных дальнейших маршрутов

GetPoint(pointA);   // координаты точки А
PrintPoint(pointA, "точки A");
GetPoint(pointB);   // координаты точки В
PrintPoint(pointB, "точки B");
GetPoint(pointC);   // координаты точки С
PrintPoint(pointC, "точки C");

startRoute[0] = Calculator(startPoint, pointA); // длина от 0 до точки А
startRoute[1] = Calculator(startPoint, pointB); // длина от 0 до точки В
startRoute[2] = Calculator(startPoint, pointC); // длина от 0 до точки С
nextRoute[0] = Calculator(pointA, pointB);     // длина между точками А и В
nextRoute[1] = Calculator(pointA, pointC);     // длина между точками А и С
nextRoute[2] = Calculator(pointB, pointC);     // длина между точками В и С

Console.WriteLine();
Console.WriteLine($"point0->pointA {startRoute[0]}");
Console.WriteLine($"point0->pointB {startRoute[1]}");
Console.WriteLine($"point0->pointC {startRoute[2]}");
Console.WriteLine();
Console.WriteLine($"pointA->pointB {nextRoute[0]}");
Console.WriteLine($"pointA->pointC {nextRoute[1]}");
Console.WriteLine($"pointB->pointC {nextRoute[2]}");
Console.WriteLine();

minRoute(startRoute); // min значение начала координат до точек A B C
nextPoint(nextRoute); // средне значение между точками A B C
