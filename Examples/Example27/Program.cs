/*Задача 27: Напишите программу, которая принимает на вход 
            число и выдаёт сумму цифр в числе.

                452 -> 11

                82 -> 10

                9012 -> 12    */

Console.Write("Введите число А: ");
int numberA = Convert.ToInt32(Console.ReadLine());

int number (int A)
{
     int sum = 0;
     while (A != 0)
     {
         sum = sum + A%10;
         A=A/10;
     }     
     return sum;  
}
 Console.WriteLine($"Сумма цифр числа {numberA} = {number(numberA)}");