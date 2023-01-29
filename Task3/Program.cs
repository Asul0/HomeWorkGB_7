// // Напишите программу реализующую методы, формирования двумерного 
// массива и массива средних арифметических значений каждого столбца.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
using static System.Console;
Clear();


Write("Введите размер матрицы через пробел: ");
string[] parameters = ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries);

double[] doubleParams = Array.ConvertAll(parameters, Convert.ToDouble);

int[] rename = Array.ConvertAll(doubleParams, Convert.ToInt32);

double[,] array = GetMatrixArray(rename[1], rename[0]);


PrintdoubleMatrixArray(array);
Write($"Среднее арифметическое каждого столбца: ");
GetMatrixArray2(array);
Write($"{rename[0]}.");


double[,] GetMatrixArray(int rows, int columns)
{
   double[,] resultArray = new double[rows, columns];
   for (int i = 0; i < rows; i++)
   {
      for (int j = 0; j < columns; j++)
      {
         resultArray[i, j] = new Random().Next(1, 15);
      }
   }
   return resultArray;
}


double[,] GetMatrixArray2(double[,] arr)
{
   double[,] arr2 = new double[arr.GetLength(0), arr.GetLength(1)];
   for (int j = 0; j < arr.GetLength(1); j++)
   {
      double sum = 0;
      for (int i = 0; i < arr.GetLength(0); i++)
      {
         sum += arr[i, j];
      }
      Console.Write($"{sum / arr.GetLength(0)}; ");
   }
   return arr2;
}

void PrintdoubleMatrixArray(double[,] inArray)
{
   for (int i = 0; i < inArray.GetLength(0); i++)
   {
      for (int j = 0; j < inArray.GetLength(1); j++)
      {
         Write($"{inArray[i, j],4} ");
      }
      WriteLine();
   }
}
