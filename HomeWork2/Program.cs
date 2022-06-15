/* Задача 13
Напишите программу, которая выводит третью цифру заданного числа
или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/

Console.WriteLine("Задача 13");
Console.WriteLine("Введите число: ");
int numb = Convert.ToInt32(Console.ReadLine());
int res;
if (numb / 100 >= 1 && numb / 100 <= 9)
{
    res = numb % 10;
    Console.WriteLine($"В числe: {numb} третья цифра -> {res} ");
}
else if (numb / 1000 >= 1 && numb / 1000 <= 9)
{
    res = numb / 10 % 10;
    Console.WriteLine($"В числe: {numb} третья цифра -> {res} ");
}
else if (numb / 10000 >= 1 && numb / 10000 <= 9)
{
    res = numb / 100 % 10;
    Console.WriteLine($"В числe: {numb} третья цифра -> {res} ");
}
else if (numb / 100000 >= 1)
{
    Console.WriteLine("Перебор!");
}
else
{
    Console.WriteLine($"В числe: {numb} -> нет третьей цифры! ");
}

/* Задача 15
Напишите программу, которая принимает на вход цифру, 
обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/

Console.WriteLine();
Console.WriteLine("Задача 15");
Console.WriteLine("Введите число, обозначающую день недели: ");
int day = Convert.ToInt32(Console.ReadLine());
if (day > 0)
{
    if (day == 6 || day % 7 == 6)
    {
        Console.WriteLine("Суббота!");
    }

    else if (day == 7 || day % 7 == 0)
    {
        Console.WriteLine("Воскресенье!");
    }

    else if (day == 1 || day % 7 == 1)
    {
        Console.WriteLine("Понедельник!");
    }

    else if (day == 2 || day % 7 == 2)
    {
        Console.WriteLine("Вторник!");
    }

    else if (day == 3 || day % 7 == 3)
    {
        Console.WriteLine("Среда!");
    }

    else if (day == 4 || day % 7 == 4)
    {
        Console.WriteLine("Четверг!");
    }

    else if (day == 5 || day % 7 == 5)
    {
        Console.WriteLine("Пятница!");
    }

}
else 
{
Console.WriteLine(" Не может быть! ");
}



///////////////////////////
///////////////////////////

// Дополнительные задачи
/* Задача 1. 
Написать программу, которая определяет, является ли
треугольник со сторонами a, b, c равнобедренным.
*/
Console.WriteLine("Задача 1*");
Console.WriteLine("Введите длину стороны a треуголька");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите длину стороны b треуголька");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите длину стороны c треуголька");
int c = Convert.ToInt32(Console.ReadLine());

if (a == b || b == c || a == c)
    Console.WriteLine("Треугольник со сторонами a, b, c является равнобедренным.");
else Console.WriteLine("Треугольник со сторонами a, b, c не является равнобедренным.");


/* Задача 2. 
На вход подаются год, номер месяца и день рождения человека, 
Определить возраст человека на момент 1 июля 2022 года.
                                      01.07.2022
*/

Console.WriteLine("Задача 2*");
Console.WriteLine("Введите день рождения человека");
int date = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите номер месяца рождения человека");
int month = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите год рождения человека");
int year = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Ваш день рождения человека {date}.{month}.{year}");
int currentDay = 1;
int currentMonth = 7;
int currentYear = 2022;
int diffYear = 0;
int diffMonth = 0;
int diffDay = 0;
// Проверка данных
if (year <= currentYear && month <= 12 && date <= 31)
{
    // Вычисление дней (здесь есть косяк из-за високоного года, не придумал как)
    if (currentDay <= date)
    {
        diffDay = 31 - date + currentDay - 1;
    }
    else
    {
        diffDay = currentDay - date;
    }

    // Вычисление месяца
    if (currentMonth <= month && currentDay <= date)
    {
        diffMonth = 12 - month + currentMonth - 1;
    }
    else if (currentMonth <= month)
    {
        diffMonth = 12 - month + currentMonth;
    }
    else if (currentMonth > month && currentDay <= date)
    {
        diffMonth = currentMonth - month - 1;
    }
    else if (currentMonth > month && currentDay > date)
    {
        diffMonth = currentMonth - month;
    }
    if (diffMonth == 12)
    {
        diffMonth = 0;
        diffYear = 1;
    }


    // Вычисление лет
    if (currentYear > year && currentMonth <= month && currentDay <= date)
    {
        diffYear = diffYear + currentYear - year - 1;
    }
    else if (currentYear > year)
    {
        diffYear = diffYear + currentYear - year;
    }
}
else
{
    Console.WriteLine("Не верные данные!");
}


Console.WriteLine($"Ваш возраст: {diffYear} лет {diffMonth} месяца {diffDay} дней");

/* Задача 3. 
Иван в начале года открыл счет в банке, вложив 1000 руб. 
Через каждый месяц размер вклада увеличивается на 1.5% от имеющейся суммы. 
Определить размер депозита через n месяцев.
*/

Console.WriteLine("Задача 3*");
Console.WriteLine("Определить размер депозита через n месяцев");
int n = Convert.ToInt32(Console.ReadLine());
double cash = 1000;
double stavka = 1.5 / 100;
int count = 1;

while (count <= n)
{
    cash = cash + cash * stavka;
    count++;
}
Console.WriteLine($"Размер депозита через {n} месяцев сoставит {cash}");


/* Задача 4.
Дано натуральное число, в котором все цифры различны. 
Определить, какая цифра расположена в нем левее: максимальная или минимальная.
*/

Console.WriteLine("Задача 4*");
Console.WriteLine("Введите натуральное число, в котором все цифры различны: ");
int number = Convert.ToInt32(Console.ReadLine());
int first = number % 10;
int second = number % 100;
if (number > 9)
{
    if (second / 10 > first)
    {
        Console.WriteLine($"цифра {second / 10} расположеная левее {first} -> максимальная");
    }

    else
    {
        Console.WriteLine($"цифра {second / 10} расположеная левее {first} -> минимальная");
    }

}
else
    {
        Console.WriteLine("Здесь нечего сравнивать");
    }

