//Homework6
//Task1. Пользователь вводит с клавиатуры M чисел. 
//Посчитайте, сколько чисел больше 0 ввёл пользователь.

/*
Console.Write("Input amount of numbers: ");
int amount = Convert.ToInt32(Console.ReadLine());
int count = 0;
for (int i = 1; i <= amount; i++)
{
  Console.Write($"Input {i} number: ");
  int temp = Convert.ToInt32(Console.ReadLine());
  if (temp > 0) count++;
}
Console.WriteLine($"You input {count} positive numbers");
*/

//Task2. Напишите программу, которая найдёт точку пересечения 
//двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
//значения b1, k1, b2 и k2 задаются пользователем.

void CoorIntersect(double k1, double k2, double b1, double b2)
{
  double x= (b2-b1)/(k1-k2);
  double y=(k1*(b2-b1))/(k1-k2)+b1;
  Console.WriteLine(x+", "+y);
}

Console.Write("Input k number of first line: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input b number of first line: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input k number of second line: ");
double k2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input b number of second line: ");
double b2 = Convert.ToDouble(Console.ReadLine());

if(k1==k2&&b1==b2) Console.WriteLine("Lines match");
else if(k1==k2&&b1!=b2) Console.WriteLine("Lines are parallel");
else CoorIntersect(k1,k2,b1,b2);


