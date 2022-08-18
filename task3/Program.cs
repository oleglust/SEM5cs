// Задайте массив. Напишите программу, которая определяет, есть ли заданное число в массиве
int[] array = GetArray(12, -9, 9);

int[] GetArray(int size, int min, int max)
{
    
   int[] result = new int[size];
   for( int i = 0; i < size; i++)
       {
        result[i] = new Random().Next(min, max + 1);
       }
        return result;
}

Console.WriteLine("Введите число:");
int num  = int.Parse(Console.ReadLine());


void CHECKING()
{
  int sum = 0;
  int n=0;
  int sizeA = array.Length;
  foreach (int i in array)
   {
    Console.Write(i + " ");
   }

  Console.WriteLine();
  while (n < sizeA)
   {
  if (array[n] == num)
     {
         sum ++;
     }
   else
     {
     sum = sum + 0;
     }  
    
    n++;
   }
   Console.Write("Ваше число в массиве встречается "+ sum +" раз");
}


 CHECKING();

  
