// // Напишите программу, которая принимает на вход 
// три числа и проверяет, может ли существовать 
// треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона 
// треугольника меньше суммы двух других сторон.

// Console.Clear();
// int A = 0;
// int B = 0;
// int C = 0;

// Console.Write("Введите длину первой стороны треугольника: ");
// while(!int.TryParse(Console.ReadLine(), out A) || A < 0) {
//     Console.Write("Ошибка! Ведите положительное число: ");
// }
// Console.Write("Введите длину второй стороны треугольника: ");
// while(!int.TryParse(Console.ReadLine(), out B) || B < 0) {
//     Console.Write("Ошибка! Ведите положительное число: ");
// }
// Console.Write("Введите длину третьей стороны треугольника: ");
// while(!int.TryParse(Console.ReadLine(), out C) || C < 0) {
//     Console.Write("Ошибка! Ведите положительное число: ");
// }

// if (A < B + C & B < A+C & C< A+B)
// {
//     Console.Write("Может! ");
// }
// else 
// {
//     Console.Write("Не может! ");
// }

//  Напишите программу, которая будет 
//  преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

/*
Console.Clear();
Console.WriteLine("Введите число: ");
int value = int.Parse(Console.ReadLine());
String BinaryCode = Convert.ToString(value, 2);// 1 способ: функция перевода из 10 в 2-ю систему
Console.WriteLine(BinaryCode);
*/

Console.Clear();
Console.WriteLine("Введите число: ");
int value = int.Parse(Console.ReadLine());

string i = " ";
while (value>0)
{
    if (value%2 != 0)
    {
        i+= "1";
    }
    else 
    {
        i+= "0";
    }
    value = value/2;
    }

    Console.WriteLine($"В двоичной системе: ");
    Console.WriteLine(String.Join(" ", i.Reverse()));