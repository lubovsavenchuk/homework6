// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

Console.Write($"Введите значения координат первой прямой:");
double b1 = Convert.ToInt32(Console.ReadLine());
double k1 = Convert.ToInt32(Console.ReadLine());
Console.Write($"Введите значения координат второй прямой:");
double b2 = Convert.ToInt32(Console.ReadLine());
double k2 = Convert.ToInt32(Console.ReadLine());
double x = (b2 - b1) / (k1 - k2);
// пересечение прямых

   // параллельность прямых
if(k1 == k2)
{
   Console.WriteLine("Прямые параллельны, точек пересечения не имеют");
}
// совпадение прямых
else if(b1 == b2)
{
   Console.WriteLine("Прямые совпадают");
}
else
{
   double y = k2 * x + b2;
   Console.WriteLine($"Прямые пересекаются. Координаты точки пересечения: ({x};{y})");
}
