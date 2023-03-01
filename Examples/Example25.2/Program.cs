Console.Write("Введите число А: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int numberB = Convert.ToInt32(Console.ReadLine());

int number (int A, int B)
{
     int result = 1;
     int i = 1;
     while (i<=B)
     {
         result = result*A;
         i++;
     }     
     return result;  
}
 Console.WriteLine($"{numberA} в степени {numberB} = {number(numberA,numberB)}"); 
