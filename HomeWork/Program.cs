/* Задача 1 
Напишите программу, которая на вход принимает два числа
и выдаёт, какое число большее, а какое меньшее.
*/
Console.WriteLine("--------------");
Console.WriteLine("Задача 1");
Console.Write("Введите число а = ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число b = ");
int b = Convert.ToInt32(Console.ReadLine());
int max;
if (a > b)
{
    Console.Write("max = "); 
    Console.WriteLine(max = a);
    Console.Write("min = "); 
    Console.WriteLine(b); 
}
else
{
    Console.Write("max = "); 
    Console.WriteLine(max = b); 
    Console.Write("min = "); 
    Console.WriteLine(a);     
}


/* Задача 2
Напишите программу, которая принимает на вход три числа
и выдаёт максимальное из этих чисел.
*/
Console.WriteLine("--------------");
Console.WriteLine("Задача 2");
Console.Write("Введите первое число   ");
int c = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число   ");
int d = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число   ");
int e = Convert.ToInt32(Console.ReadLine());
int res = c;

if (c > res) res = c;
if (d > res) res = d;
if (e > res) res = e;

Console.Write("max = "); 
Console.WriteLine(res); 


/* Задача 3
Напишите программу, которая на вход принимает число и выдаёт,
является ли число чётным (делится ли оно на два без остатка).
*/
Console.WriteLine("--------------");
Console.WriteLine("Задача 3");
Console.Write("Введите число   ");
int f = Convert.ToInt32(Console.ReadLine());
if (f > 0)
{
int result = f%2;
if (result == 0) Console.WriteLine("Число четное!"); 
else Console.WriteLine("Число нечетное!"); 
}
else Console.WriteLine("Вы ввели не правильное число, до свидания!");


/* Задача 4
Напишите программу, которая на вход принимает число (N),
а на выходе показывает все чётные числа от 1 до N.
*/
Console.WriteLine("--------------");
Console.WriteLine("Задача 4");
Console.Write("Введите число   ");
int n = Convert.ToInt32(Console.ReadLine());
int m = 1;
if (n > 0)
{
   while (n >= m)
   {
       if (m%2 == 0)
       {
          Console.Write(m);
          Console.Write(" ");
       }
     m++;
   }
}
else Console.WriteLine("Вы ввели не правильное число, до свидания!");
Console.WriteLine();


/////////////////////////////////////////////////
/////////////////////////////////////////////////
/* Задача 1. 
Пользователь вводит число N (N > 0). 
Программа должна вывести N единиц на экран.
N = 4 -> 1, 1, 1, 1
N = 2 -> 1, 1
*/
Console.WriteLine("--------------");
Console.WriteLine("--------------");
Console.WriteLine("Задача 1* ");
Console.Write("Введите любое число больше нуля: ");
int num = Convert.ToInt32(Console.ReadLine());
int i = 1;
if (num > 0) 
{
while (i <= num)
{
   Console.Write("1");
   Console.Write(" "); 
   i++;
}
Console.WriteLine();
}
else Console.WriteLine("Вы ввели не правильное число, до свидания!");


/* Задача 2. 
Даны два числа a, b, такие что a < b. 
Вывести на экран сколько раз число a поместиться в числе b.
*/
Console.WriteLine("--------------");
Console.WriteLine("Задача 2* ");
Console.WriteLine("Введите два числа a, b, такие что a < b ");
Console.Write("Введите число a: ");
int k = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число b: ");
int l = Convert.ToInt32(Console.ReadLine());
int sum = a;
int r = 0;
if (a < b)
{
   while (sum <= l)
   {
      sum = sum + k;
      r++;
   } 
  Console.Write("Число a поместиться в числе b  ");
  Console.Write(r);
  Console.WriteLine(" раз"); 

}

else Console.WriteLine("Вы ввели не правильные числа, до свидания!");


/* Задача 3. 
На ввод подаётся рост трёх спортсменов. 
Расположить их от большего к меньшему.
*/
Console.WriteLine("--------------");
Console.WriteLine("Задача 3* ");
Console.WriteLine("Введите рост трёх спортсменов. ");
Console.Write("Введите рост первого спортсмена: ");
int a1 = Convert.ToInt32(Console.ReadLine());           //13
Console.Write("Введите рост второго спортсмена: ");
int a2 = Convert.ToInt32(Console.ReadLine());           //9
Console.Write("Введите рост третьего спортсмена: ");
int a3 = Convert.ToInt32(Console.ReadLine());           //15
int mini = a1;  
int midi = a1;  
int maxi = a1;  
if (a1 < mini) mini = a1;
else if(a1 > maxi) maxi = a1;
if (a2 < mini) mini = a2;
else if (a2 > maxi) maxi = a2;
if (a3 < mini) mini = a3;
else if (a3 > maxi) maxi = a3;
if (a1 > mini && a1 < maxi) midi = a1;
if (a2 > mini && a2 < maxi) midi = a2;
if (a3 > mini && a3 < maxi) midi = a3;
Console.WriteLine(maxi);
Console.WriteLine(midi);
Console.WriteLine(mini);


/* Задача 4. 
Дано N секунд. 
Вывести время в формате часы:минуты:секунды.
N = 72334 -> 20:5:34 
*/
Console.WriteLine("--------------");
Console.WriteLine("Задача 4* ");
Console.Write("Введите количество секунд: ");
int sec = Convert.ToInt32(Console.ReadLine());
// 72334 / 3600 = 20.093
// 72334 % 60 = 34
// 72334 % 3600 = 334     334 / 60 = 5.567
int huor = sec / 3600;                  
int minute = sec % 3600 / 60;           
int secOut = sec % 60;
Console.Write("Время: ");
Console.Write(huor);
Console.Write(":");
Console.Write(minute);
Console.Write(":");
Console.WriteLine(secOut);
Console.Write("");
Console.Write("Программа закончена ");

