// Найдите сумму произведений пар чисел в одномерном целочисленном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Если кол-во элементов нечетное, то элемент посередине не учитывать. Результат сложения вывести на экран. 1, 3, 8, 3, 2 -> 11

int [] arr = new int [5];
int result  = 0;
int index = 0;
while (index < arr.Length)
{
   arr[index] = new Random().Next(1, 10);
   Console.Write(arr[index] + " ");
   index++;
}
Console.WriteLine();
for(index = 0; index < arr.Length/2; index++)
{
   result = result + (arr[index] * arr[arr.Length - (index + 1)]);
}
Console.WriteLine(result);