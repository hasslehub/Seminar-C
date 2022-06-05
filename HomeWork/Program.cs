// Задача 1
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
}
else
{
    Console.Write("max = "); 
    Console.WriteLine(max = b);     
}

// Задача 2
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

// Задача 3
Console.WriteLine("--------------");
Console.WriteLine("Задача 3");
Console.Write("Введите число   ");
int f = Convert.ToInt32(Console.ReadLine());
int result = f%2;
if (result == 0) Console.WriteLine("Число четное!"); 
else Console.WriteLine("Число нечетное!"); 

// Задача 4
Console.WriteLine("--------------");
Console.WriteLine("Задача 4");
Console.Write("Введите число   ");
int n = Convert.ToInt32(Console.ReadLine());
int m = 1;
while (n >= m)
{
  if (m%2 == 0)
   {
       Console.Write(m);
       Console.Write(" ");
   }
   m++;
}