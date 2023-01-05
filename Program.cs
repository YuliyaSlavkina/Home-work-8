//     Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

//     int [,] Create2dArray(int rows, int cols, int min, int max){
//       int[,] array = new int[rows, cols];
//       for(int i = 0; i < rows; i++){
//         for (int j = 0; j <  cols; j++){
//             array[i,j]= new Random().Next(min,max);
//         }
//       }
//       return array;
//     }

//     void Show2dArray(int[,] array){
//       for(int i = 0; i < array.GetLength(0); i++){
//         for (int j = 0; j <  array.GetLength(1); j++){
//           Console.Write(array[i,j] + " ");
//         }
//         Console.WriteLine();
//      }
//     }

//     int[,] SortingArray(int[,] array){
//       for(int i = 0; i < array.GetLength(0); i++){
//         for (int j = 0; j <  array.GetLength(1); j++){
//           for (int k = array.GetLength(1)-1; k >  j; k--){
//             if(array[i,k] < array[i,k-1]){

//               int temp = array[i,k];
//               array[i,k] = array[i, k-1];
//               array[i, k-1] = temp;
//             }            
//           }          
//         }        
//       }
//       return array;
//     }



//     Console.Write("Enter numb of rows: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter numb of cols: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter min: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter max: ");
// int max = Convert.ToInt32(Console.ReadLine());
// int[,] array = Create2dArray(m, n, min, max);
// Show2dArray(array);  
// Console.WriteLine();
// int[,] sortarray = SortingArray(array);
// Show2dArray(sortarray);


//     **Задача 56:** Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
//     Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

// int [,] Create2dArray(int rows, int cols, int min, int max){
//   int[,] array = new int[rows, cols];
//   for(int i = 0; i < rows; i++){
//       for (int j = 0; j <  cols; j++){
//           array[i,j]= new Random().Next(min,max);
//       }
//    }
//    return array;
// }

// void Show2dArray(int[,] array){
//   for(int i = 0; i < array.GetLength(0); i++){
//       for (int j = 0; j <  array.GetLength(1); j++){
//           Console.Write(array[i,j] + " ");
//       }
//       Console.WriteLine();
//    }
// }

// void RowSum (int[,] array){
//   int sum = Int32.MaxValue;
//   int rownumber = 0;
//   for(int i = 0; i < array.GetLength(0); i++){
//     int currentsum = 0;    
//     for (int j = 0; j < array.GetLength(1); j++){
//       currentsum+=array[i,j];     
//       }  
//     if(currentsum < sum){
//           sum = currentsum;
//           rownumber = i;   
//     }  
//   }
//   Console.WriteLine($"строка с минимальной суммой элементов: {rownumber} ");
// }





// Console.Write("Enter numb of rows: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter numb of cols: ");
// int cols = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter min: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter max: ");
// int max = Convert.ToInt32(Console.ReadLine());
// int[,] array = Create2dArray(rows, cols, min, max);
// Show2dArray(array);
// RowSum(array);


//     Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

// int [,] CreateFirstMatrix(int rows, int cols, int min, int max){
// int[,] firstMatrix = new int[rows, cols];
// for(int i = 0; i < rows; i++){
//     for (int j = 0; j <  cols; j++){
//         firstMatrix[i,j]= new Random().Next(min,max);
//     }
//  }
//  return firstMatrix;
// }


// int [,] CreateSecondtMatrix(int rows2, int cols2, int min2, int max2){
// int[,] secondMatrix = new int[rows2, cols2];
// for(int i = 0; i < rows2; i++){
//     for (int j = 0; j <  cols2; j++){
//         secondMatrix[i,j]= new Random().Next(min2,max2);
//     }
//  }
//  return secondMatrix;
// }

// void ShowMatrix(int[,] array){
// for(int i = 0; i < array.GetLength(0); i++){
//     for (int j = 0; j <  array.GetLength(1); j++){
//         Console.Write(array[i,j] + " ");
//     }
//     Console.WriteLine();
//  }
// }

// int[,] MatrixMultiplication(int[,] firstMatrix, int[,] secondMatrix){
//   int[,]matrix = new int[firstMatrix.GetLength(0), secondMatrix.GetLength(1)];

//   for(int i = 0; i < firstMatrix.GetLength(0); i++){
//     for(int j = 0; j < secondMatrix.GetLength(1); j++){
//       matrix[i,j] = 0;
//       for(int m = 0; m < firstMatrix.GetLength(1); m++ ){
//         matrix[i,j] += firstMatrix[i,m]*secondMatrix[m,j]; 
//       }
//     }
//   }

//   if(firstMatrix.GetLength(0) != secondMatrix.GetLength(1)){
//       Console.WriteLine("Multiplication is not possible.");
//   }
//   return matrix;
// }


// int rows=2;
// int cols=2;
// int min=0;
// int max=9;
// int rows2=2;
// int cols2=2;
// int min2=0;
// int max2=9;

// int[,] matrx1 = CreateFirstMatrix(rows,cols,min,max);
// ShowMatrix(matrx1);
// Console.WriteLine();
// int[,] matrx2 = CreateSecondtMatrix(rows2, cols2, min2, max2);
// ShowMatrix(matrx2);
// Console.WriteLine();
// int[,] resultMatrx = MatrixMultiplication(matrx1, matrx2);
// ShowMatrix(resultMatrx); 

//    Задача 60. ...Сформируйте трёхмерный массив из 
// неповторяющихся двузначных чисел. Напишите программу, которая будет 
// построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)


int [,,] Create3dArray(int z, int rows, int cols, int min, int max){
  int[,,] array = new int[z, rows, cols];
  for(int i = 0; i < z; i++){
    for(int j = 0; j < rows; j++){
        for (int k = 0; k <  cols; k++){                    
             array[i,j,k]= new Random().Next(min,max);          
        }
     }
  }
    return array;
}

void Show3dArray(int[,,] array){
  for(int i = 0; i < array.GetLength(0); i++){
    for (int j = 0; j <  array.GetLength(1); j++){  
      Console.WriteLine();
      for (int k = 0; k <  array.GetLength(2); k++){
        Console.Write($"{array[i,j,k]}{(i,j,k)} ");
      } 
    }
    Console.WriteLine();
  }
}


int z = 2;
int rows = 2;
int cols = 2;
int min =  0;
int max = 100;

int[,,] array = Create3dArray(z, rows, cols, min, max);
Show3dArray(array);

// Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

// int[,] Create2dArray(int n)
// {
//     int[,] array = new int[n, n];
//     int number = 1;
//     int i = 0;
//     int j = 0;
//     while (number <= n * n)
//     {
//         array[i, j] = number;
//         if (i <= j + 1 && i + j < n - 1)
//             j++;
//         else if (i < j && i + j >= n - 1)
//             i++;
//         else if (i >= j && i + j > n - 1)
//             j--;
//         else
//             i--;
//         number++;
//     }
//     return array;
// }


// void Show2dArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }

//         Console.WriteLine("");
//     }
// }


// int n = 4;
// int[,] myArray = Create2dArray(n);
// Show2dArray(myArray);