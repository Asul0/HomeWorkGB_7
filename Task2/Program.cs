//  Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает 
// значение этого элемента или же указание, что такого элемента нет.
// Во вводе первая цифра - номер строки, вторая - столбца. Цифры не больше 9.
// Например, задан массив:
//   1 4 7 2
//  5 9 2 3
//  8 4 2 4
//  1;7 -> такого элемента в массиве нет
//  1;1 -> 9

using static System.Console;
Clear();


Write("Введите размер строки: ");
int numRows = Convert.ToInt32(ReadLine());
Write("Введите размер столбца: ");
int numColums = Convert.ToInt32(ReadLine());
int[,] array = new int[5, 6];
GetMatrixArray(array);
PrintMatrixArray(array);

if (numRows < array.GetLength(0) && numColums < array.GetLength(1))
{
   WriteLine(array[numRows, numColums]);
}
else
{
   WriteLine($"{numRows};{numColums} такого элемента в массиве нет");
}


int[,] GetMatrixArray(int[,] array1)
{
   for (int i = 0; i < array1.GetLength(0); i++)
   {
      for (int j = 0; j < array1.GetLength(1); j++)
      {
         array1[i, j] = new Random().Next(1, 10);
      }
   }
   return array1;
}


void PrintMatrixArray(int[,] inArray)
{
   for (int i = 0; i < inArray.GetLength(0); i++)
   {
      for (int j = 0; j < inArray.GetLength(1); j++)
      {
         Write($"{inArray[i, j],3}");
      }
      WriteLine();
   }
}
