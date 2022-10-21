/* Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)*/
int b1;
Console.Write("Введите число " );
int.TryParse(Console.ReadLine(), out b1);

int k1;
Console.Write("Введите число " );
int.TryParse(Console.ReadLine(), out k1);

int b2;
Console.Write("Введите число " );
int.TryParse(Console.ReadLine(), out b2);

int k2;
Console.Write("Введите число " );
int.TryParse(Console.ReadLine(), out k2);

double x = (double)(b2 - b1) / (k1 - k2);
double y = (double)k1 * x + b1;
 

 
Console.WriteLine($"Пересечение в точке: ({x};{y})");

