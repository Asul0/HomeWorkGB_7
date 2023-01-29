// Задача 47.Напишите программу реализующую метод,
//который возвращает массив размером m×n, заполненный 
//случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

using static System.Console;
Clear();


Write("Введите размер матрицы через пробел: ");
string[] parameters = ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries);

double[] doubleParams = Array.ConvertAll(parameters, Convert.ToDouble);

int[] rename = Array.ConvertAll(doubleParams, Convert.ToInt32);

double[,] array = GetMatrixArray(rename[0], rename[1]);
PrdoubleMatrixArray(array);

double[,] GetMatrixArray(int rows, int columns)
{
   double[,] resultArray = new double[rows, columns];
   for (int i = 0; i < rows; i++)
   {
      for (int j = 0; j < columns; j++)
      {
         resultArray[i, j] = Convert.ToDouble(new Random().Next(-100, 100)) / 10;
      }
   }
   return resultArray;
}

void PrdoubleMatrixArray(double[,] inArray)
{
   for (int i = 0; i < inArray.GetLength(0); i++)
   {
      for (int j = 0; j < inArray.GetLength(1); j++)
      {
         Write($"{inArray[i, j],5} ");
      }
      WriteLine();
      
   }
}
