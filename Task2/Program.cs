/* Задача 43: Напишите программу, которая найдёт точку 
пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)*/

double b1 = asknum("b1");
double k1 = asknum("k1");
double b2 = asknum("b2");
double k2 = asknum("k2");

double[] crospoint = getcross(b1, k1, b2, k2);

if (k1!=k2) 
{Console.WriteLine($"точка пересечения графиков {k1}*X + {b1} и {k2}*X + {b2} -> ({String.Join(", ", crospoint)}) ");}
else Console.WriteLine ("Прямые не пересекаются");

double asknum(string name)
{
    Console.Write($"Введите число {name}: ");
    double n = double.Parse(Console.ReadLine()!);
    return n;
}

double[] getcross(double b1, double k1, double b2, double k2)
{
    double[] answ = new double[2];
    answ[0] = (b2 - b1) / (k1 - k2);
    answ[1] = (k1 * answ[0]) + b1;
    return answ;
}

//Console.WriteLine($"{s:f2}"); // 2 знака после запятой