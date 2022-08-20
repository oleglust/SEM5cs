// Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях. (индексы идут с 0, значит нам нужны ЧЕТНЫЕ значения индексов)
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
   if (n % 2 == 0 )
     {
         sum = sum+array[n];
     }
   else
     {
     sum = sum + 0;
     }  
     
}
   Console.Write("Сумма чисел под нечетными индексами =  "+ sum );
}


 CHECKING();

  