// Заменяет элементы массива с положительных на отризательные


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


void Reverse()
{
  int n=0;
  int sizeA = array.Length;
  foreach (int i in array)
   {
    Console.Write(i + " ");
   }

  Console.WriteLine();
  while (n < sizeA)
   {
  if (array[n]>0)
     {
         array[n]= array[n] - (2*array[n]);
     }
   else
     {
    array[n]= array[n] - (2*array[n]);
     }  
    Console.Write(array[n]+" ");
    n++;
   }
}


 Reverse();

  