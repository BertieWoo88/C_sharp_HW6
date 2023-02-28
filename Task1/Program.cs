/* Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2

1, -7, 567, 89, 223-> 3 */


// string[] st = Console.ReadLine().Split(' ');
// int A = int.Parse(st[0]);
// int B = int.Parse(st[1]);
// int C = int.Parse(st[2]);
// int A = asknum("A");
// int B = asknum("B");
// int C = asknum("C");
// Trianglecheck(A, B, C);

// int asknum (string name)
// {
//     Console.Write($"Введите число {name}: ");
//     int n = int.Parse(Console.ReadLine()!);
//     return n; 
// }
Console.Write ("Введите числа через пробел: ");
string [] st = Console.ReadLine().Split(' ');

Console.WriteLine(sumPlus(st));

int sumPlus (string[] array)
{
int count = 0;
    foreach ( string el in array)
{ 
 if ( int.Parse(el)>0) count++; }
return count;
}
 