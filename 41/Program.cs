 /*Пользователь вводит с клавиатуры M чисел. 
 Посчитайте, сколько чисел больше 0 ввёл пользователь.*/

int [] array= new int[5];
for (int i = 0; i < array.Length; i++)
{
    array[i]= new Random ().Next(-10,10);
    Console.Write($"{array[i]} ");}
       int count=0;
   for (int i = 0; i < array.Length; i++)
{
    if (array[i] > 0)
    {
        count++;
    }
}
Console.WriteLine($"Кол-во элементов > 0: {count}");
    