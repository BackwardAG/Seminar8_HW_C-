// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4. 
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07


// int[,] FillMatrixInOrder(int rows, int cols)
// {
//     int index = 1;
//     int[,] matr = new int[rows, cols];

//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < cols; j++)
//         {
//             matr[i, j] = index;
//             index += 1;
//         }
//     }

//     return matr;
// }

// заполнять по спирали сразу

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] / 10 <= 0)
            {
                Console.Write($" {matrix[i, j]} ");

            }
            else
            {
                Console.Write($"{matrix[i, j]} ");
            }

        }
        Console.WriteLine();
    }
}

int[,] matrix = new int[4, 4];

int element = 1;
int i = 0;
int j = 0;

while (element <= matrix.GetLength(0) * matrix.GetLength(1))
{
    matrix[i, j] = element;
    element++;
    if (i <= j + 1 && i + j < matrix.GetLength(1) - 1)
        j++;
    else if (i < j && i + j >= matrix.GetLength(0) - 1)
        i++;
    else if (i >= j && i + j > matrix.GetLength(1) - 1)
        j--;
    else
        i--;
}

PrintMatrix(matrix);
System.Console.WriteLine();