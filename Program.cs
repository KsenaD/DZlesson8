// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию 
//элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

// Console.Write ("Введите количество строк:  ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write ("Введите количество столбцов:  ");
// int columns = Convert.ToInt32(Console.ReadLine());
// int[,]matrix = new int[rows,columns];
//     for (int i=0; i<matrix.GetLength(0); i++)
//     {
//         for (int j=0; j<matrix.GetLength(1); j++)
//         {
//             matrix[i,j]=new Random().Next(10);
//             Console.Write(matrix[i,j]+ "\t");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// int temp;
// for (int i = 0; i < matrix.GetLength(0); i++)           //цикл по количеству строк
// {
//     for (int j = 0; j < matrix.GetLength(1)-1;j++)      //количество итераций
//     {
//         for (int k = 1; k < matrix.GetLength(1); k++)   // сортировка
//         {
//            if(matrix[i,k]>matrix[i,k-1]) 
//            {
//             temp=matrix[i,k];
//             matrix[i,k]=matrix[i,k-1];
//             matrix[i,k-1]=temp;
//            }
//         }
//     }
// }
// for (int i = 0; i < matrix.GetLength(0); i++)
// {
//     for (int j=0; j<matrix.GetLength(1); j++)
//     {
//     Console.Write(matrix[i,j]+ "\t");
//     }
//     Console.WriteLine();
// }


// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

// Console.Write ("Введите количество строк:  ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write ("Введите количество столбцов:  ");
// int columns = Convert.ToInt32(Console.ReadLine());
// int[,]matrix = new int[rows,columns];
//     for (int i=0; i<matrix.GetLength(0); i++)
//     {
//         for (int j=0; j<matrix.GetLength(1); j++)
//         {
//             matrix[i,j]=new Random().Next(10);
//             Console.Write(matrix[i,j]+ "\t");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// int Sum=0;
// int sumTemp=0;
// int min=0;
// for (int i = 0; i < matrix.GetLength(0); i++)
// {
//     for (int j =0; j< matrix.GetLength(1); j++)
//     {
//         Sum = Sum + matrix[i,j];
//     }
//    if (Sum < sumTemp || i==0)
//    {
//     min = i;
//     sumTemp=Sum;
//    }     
// }
// Console.WriteLine($"наименьшая сумма элементов: {min} строка");
 

//  Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18


// 


// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)


// int[]Arr = new int[90];
// int[,,]Array = new int[3,3,3];
// int C = 10;
// int m=0;
// int temp;

// for (int i=0; i<90;i++)
// {
//     Arr[i]=C;
//     C++;
// }
   
// for (int i = 89; i>0; i--)
// {
//     int j = new Random().Next(0,i+1);
//     temp = Arr[i];
//     Arr[i] = Arr[j];
//     Arr[j] = temp;
// }

// for (int i=0; i<3; i++)
// {
//     for (int j=0; j<3; j++)
//     {
//         for (int k=0; k<3; k++)
//         {
//             Array[i,j,k]=Arr[m];
//             m++;
//         }
//     }
// }

// for (int i=0; i<3; i++)
// {
//     for (int j=0; j<3; j++)
//     {
//         for (int k=0; k<3; k++)
//         {
//             Console.Write($"{Array[i,j,k]}({i},{j},{k})\t");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
//     Console.WriteLine();
// }

// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int size = 4;               //размерность массива
int[,]Arr = new int[size,size];
int a = Arr.GetLength(0)-1; //максимум по горизонтали
int b = Arr.GetLength(1)-1; //максимуи по вертикали
int c = 0;                  //минимум по горизонтали
int d = 0;                  //минимум по вертикали
int i = 0;
int x = 0;


while (x<(size*size))  
{
while (i<=a)           //вправо
{
    Arr[d,i] = x;
    x++; 
    i++;
}
i=d+1;
d++;
while (i<=b)           //вниз
{
    Arr[i,a] = x;
    x++;
    i++;
}
i=a-1;
a--;
while (i>=c)             //влево
{
    Arr[b,i]=x;
    x++;
    i--;
}
i=b-1;
b--;
while (i>=d)             //вверх
{
Arr[i,c] = x;
x++;
i--;
}
i=c+1;
c++;

}



for (int m=0; m<size; m++)
{
   for (int n=0; n<size; n++)
      {
      Console.Write(Arr[m,n]+"\t");
      }
      Console.WriteLine();
}
