// Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
int[] array = GetArray(9, 100, 1000);

int[] GetArray(int size, int min, int max)
{
    
   int[] result = new int[size];
   for( int i = 0; i < size; i++)
       {
        result[i] = new Random().Next(min, max + 1);
       }
        return result;
}


void CHECKING()
{
  int sum = 0;
  int sizeA = array.Length;
  foreach (int i in array)
   {
    Console.Write(i + " ");
   }

  Console.WriteLine();

for (int n = 0; n < sizeA; n++)
{
   if (array[n] % 2 == 0 )
     {
         sum ++;
     }
   else
     {
     sum = sum + 0;
     }  
     
}
   Console.Write("Четные числа  встречаются "+ sum +" раз");
}


 CHECKING();

  