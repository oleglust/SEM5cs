// задайте одномерный массив из 123 сл. чисел. 
//Найдите количество элтов значение которых от 10 до 99
int[] array = GetArray(123, -99, 100);

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
   if (array[n] > 10 | array[n] >= 10 && array[n]<99)
     {
         sum ++;
     }
   else
     {
     sum = sum + 0;
     }  
     
}
   Console.Write("Числа от 10 до 99 встречаются "+ sum +" раз");
}


 CHECKING();

  

