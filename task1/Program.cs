// Задайте массив из 12 чисел, от -9 до 9. 
//Найдите сумму отрицательных и положительных эл-тов

//задаем массив через функцию
int[] array = GetArray(12, -9, 9);
//создаем функцию, в функцию указываем 3 значения
int[] GetArray(int size, int min, int max)
{
    //задаем резулт, который в итоге вернем, присваеваем ему новый массив , определенной длины
int[] result = new int[size];
//создаем цикл, который с 0 индекса до 12 создает рандомные числа от мин до макс.
for( int i = 0; i < size; i++)
{
    result[i] = new Random().Next(min, max + 1);
}
    //возыращаем резулт
return result;
}
int pos = 0;
int neg = 0;
//Для каждого i(переменной) в array(массиве)
foreach (int i in array)
{
    // прибавлем к pos i или 0, в зависимости от того, больше i чем ноль или нет
    Console.Write(i + " ");
   pos += i>0 ? i : 0;
   neg += i<0 ? i : 0;
}
Console.WriteLine();
Console.WriteLine("NEG = "+ neg);
Console.WriteLine("POS = "+ pos);