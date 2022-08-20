// Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.

int[] array = GetArray(4, 0, 10);

int[] GetArray(int size, int min, int max)
{
    
   int[] result = new int[size];
   for( int i = 0; i < size; i++)
       {
        result[i] = new Random().Next(min, max + 1);
       }
        return result;
}

Console.WriteLine("Массив:");
void CHECKING()
{
  int min = Int32.MaxValue;
  int max = Int32.MinValue;
  int sizeA = array.Length;
  foreach (int i in array)
   {
    Console.Write(i + " ");
   }

  Console.WriteLine();

for (int n = 0; n < sizeA; n++)
{
   if (array[n] > max )
     {
         max = array[n];
     }
  if (array[n] < min )
     {
         min = array[n];
     }
     
}
   Console.WriteLine("min =  "+ min );
   Console.WriteLine("max = "+ max );
   Console.WriteLine("разность = "+ (max - min) );
}


 CHECKING();

  