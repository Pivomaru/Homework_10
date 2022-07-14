/* Задача 72: Заданы 2 массива: info и data. В массиве info хранятся двоичные
представления нескольких чисел (без разделителя). В массиве data хранится
информация о количестве бит, которые занимают числа из массива info.
Напишите программу, которая составит массив десятичных представлений чисел
массива data с учётом информации из массива info.

входные данные:
- data = {0, 1, 1, 1, 1, 0, 0, 0, 1 }
- info = {2, 3, 3, 1 }
выходные данные:
- 1, 7, 0, 1 */

bool Check(int[] data, int[] info)
{
     int sum = 0;
     for (int i = 0; i < info.Length; i++)
     {
        sum += info[i];
     }
     if (sum == data.Length)
    {
         return true;
     }
     return false;
 }
 int[] ToDec(int[] data, int[] info)
 {
     int[] res = new int[info.Length];
     int count = 0;
     for (int i = 0; i < info.Length; i++)
    {
        int n = info[i] - 1;
         int num = 0;
        for (int j = count; j < count + info[i]; j++)
         {
             num += data[j]* (int)Math.Pow(2, n);
             n--;
        }
        count = count + info[i];
        res[i] = num;
   }
    return res;
 }


  int[] data = { 0, 1, 1, 1, 1, 0, 0, 0, 1 };
 int[] info = { 2, 3, 3, 1 };
 if (Check(data, info) == true)
 {
     int[] result = new int[info.Length];
     result = ToDec(data, info);
     for (int i = 0; i < result.Length; i++)
     {
         Console.Write(result[i] + " ");
     }
     Console.WriteLine();
 }
 else
 {
    Console.WriteLine("Данные массивы не подходят для решения поставленной задачи;(");
 }