/*
Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

6, 1, 33 -> [6, 1, 33]
*/
Console.Write("Введите число элементов массива: ");
int array = Convert.ToInt32(Console.ReadLine());

int[] GetBinaryArrey(int size)
{
   int[] array = new int[size];
   for( int i = 0; i<size; i++)
      {
              array[i]=new Random().Next(1000);  
      }  
      return array; 
}
int[] resultArray = GetBinaryArrey(array);
 Console.WriteLine($"Массив: [{String.Join(", ", resultArray)}]");
