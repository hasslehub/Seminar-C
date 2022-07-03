/*
Задача 64: 
Задайте значения M и N. 
Напишите программу, которая выведет все натуральные числа 
кратные 3-ём в промежутке от M до N.
M = 1; N = 9. -> "3, 6, 9"  M = 13; N = 20. -> "15, 18"
*/
/*
Console.WriteLine();
Console.WriteLine("Задача 64");
Console.WriteLine("Введите числовой промежуток ...");
Console.Write("от ");
int m1 = Convert.ToInt32(Console.ReadLine());
Console.Write("до ");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.Write($"Числа кратные 3 в промежутке от {m1} до {n1} -> ");
Recursion64(m1, n1);
Console.WriteLine();
void Recursion64(int M, int N)
{
    if (M > N)
        return;
    if (M % 3 == 0)
        Console.Write($"{M}  ");

    Recursion64(M + 1, N);
}

/*
Задача 66: Задайте значения M и N. 
Напишите программу, которая найдёт сумму натуральных элементов 
в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/
/*
Console.WriteLine();
Console.WriteLine("Задача 66");
Console.WriteLine("Введите числовой промежуток ...");
Console.Write("от ");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.Write("до ");
int numberN = Convert.ToInt32(Console.ReadLine());
Recursion66(numberM, numberN);
void Recursion66(int M, int N, int sum = 0)
{
    if (M > N)
        return;
    sum += M;
    if (M == N)
        Console.WriteLine($"Сумма чисел в промежутке от {numberM} до {numberN} = {sum}");
    Recursion66(M + 1, N, sum);

}

/*
Задача 68: 
Напишите программу вычисления функции Аккермана 
с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 3, n = 2 -> A(m,n) = 29

         n + 1,                   m = 0;
A(m,n) = A(m - 1, 1),             m > 0, n = 0;
         A(m - 1, A(m, n - 1)),   m > 0, n > 0.

A(0,0) = 1;  A(1,0) = 2; A(2,0) = 3; A(3,0) = 5;  A(4,0) = 13;
A(0,1) = 2;  A(1,1) = 3; A(2,1) = 5; A(3,1) = 13; A(4,1) = 65533;
A(0,2) = 3;  A(1,2) = 4; A(2,2) = 7; A(3,2) = 29; 
A(0,3) = 4;  A(1,3) = 5; A(2,3) = 9; A(3,3) = 61;
A(0,4) = 5;  A(1,4) = 6; A(2,4) = 11; A(3,4) = 125;

*//*
Console.WriteLine();
Console.WriteLine("Задача 68");
Console.WriteLine("Функция Аккермана A(m,n)");
Console.Write("Введите m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите n: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Функция Аккермана A({m},{n}) = {Ack(m, n)} ");

int Ack(int m, int n)
{
    if (m == 0) return n + 1;
    else if (n == 0) return Ack(m - 1, 1);
    else return Ack(m - 1, Ack(m, n - 1));
}


/*
Знакомство с языками программирования. Семинар 9.
Дополнительные задачи.

Задача 1. 
Дано предложение. Напишите рекурсивный метод, 
подсчитывающий количество слов в данном предложении. 
Словом считается последовательность символов без пробелов.
*/
/*
Console.WriteLine();
Console.WriteLine("Задача 1*");

string note = "Напишите рекурсивный метод, подсчитывающий количество слов в данном предложении.";
char[] simbol = { ' ', '.'};
int count = 0;
Console.WriteLine(note);
Console.Write("Количество слов в данном предложении ");
Search(note, simbol, 0, 0);
Console.WriteLine(count);

void Search(string text, char[] alphabet, int i, int j)
{

    if (i < text.Length)
    {
        if (j < alphabet.Length)
        {
            if (text[i] == alphabet[j])
            {
                count++;
            }

            Search(note, simbol, i, j + 1);
        }

        else Search(note, simbol, i + 1, 0);

    }


}


/*
Задача 2. 
Известно, что пароль длиной 3 символа состоит из 
латинских букв строчного регистра и цифр от 0 до 9. 
Напишите рекурсивный метод, который перебирает все комбинации паролей. 
*/

// Собрал из лекции
Console.WriteLine();
Console.WriteLine("Задача 2*");
char[] alphabet1 = {'a', 'b', 'c', 'd', 'e', 'f', 'g',
                  'h', 'i', 'j', 'k', 'l', 'm', 'n',
                  'o', 'p', 'q', 'r', 's', 't', 'u',
                  'v', 'w', 'x', 'y', 'z', '0', '1',
                  '2', '3', '4', '5', '6', '7', '8', '9'};

int countPin = 0; // счетчик pin
Random rand = new Random();
int pinRand = rand.Next(1, 46656);
FindPin(alphabet1, new char[3]); // из алфавита собрать все вожможные варианты из 3 символов

void FindPin(char[] alphabet, char[] word, int length = 0)
{
    if (length == word.Length)
    {
        countPin++;
        if (countPin == pinRand)
        {
          Console.WriteLine($" Случайная комбинация пароля: {countPin} -> {new String(word)}");  
        }
        
        return;
    }

    for (int i = 0; i < alphabet.Length; i++)
    {
        word[length] = alphabet[i];
        FindPin(alphabet, word, length + 1);
    }
    //
}
Console.WriteLine($" Всего комбинаций паролей: {countPin}");



/*
Задача 3. 
Даны два числа a, b. 
Сложите их, используя только операции инкремента и декремента.
*/


/*
Задача 4. 
Даны два числа a, b. 
Перемножьте их, используя только операции инкремента и декремента.
*/