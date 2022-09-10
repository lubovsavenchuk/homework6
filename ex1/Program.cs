// Программа запрашивает натуральное число M, пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

Console.WriteLine("Input quantity of numbers: ");
int M = Convert.ToInt32(Console.ReadLine());

int [] arr = new int[M];
int count = 0;
for(int i = 0; i < arr.Length; i++)
{
   Console.Write($"Input {i} number:\t");
   arr[i] = Convert.ToInt32(Console.ReadLine());
   
}
Console.WriteLine("Here are the numbers: ");
for(int i = 0; i < arr.Length; i++)
{
   Console.WriteLine(arr[i]);
   if(arr[i] > 0)
   {
      count++;
   }
}
Console.WriteLine($"Quantity of positive numbers is: {count}");


