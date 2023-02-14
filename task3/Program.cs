// Задача 58: Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int[,] FillMatrix(int rows, int cols)
{
    Random rand = new Random();
    int[,] matr = new int[rows, cols];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            matr[i, j] = rand.Next(2, 5);
        }
    }

    return matr;
}

void PrintMatrix(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            System.Console.Write(matr[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}


int[,] MatrixMultiplication(int[,] matrixOne, int[,] matrixTwo)
{
    int[,] matrixR = new int[matrixOne.GetLength(0),matrixTwo.GetLength(1)];
    for (int i = 0; i < matrixOne.GetLength(0); i++)
    {
        for (int j = 0; j < matrixOne.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < matrixTwo.GetLength(1); k++)
            {
                sum += matrixOne[i, k] * matrixTwo[k, j];
            }
            matrixR[i, j] = sum;
        }
    }
    return matrixR;

}

int[,] matrixOne = FillMatrix(2, 2);
int[,] matrixTwo = FillMatrix(2, 2);

int[,] matrixResult = MatrixMultiplication(matrixOne,matrixTwo);

PrintMatrix(matrixOne);
System.Console.WriteLine();
PrintMatrix(matrixTwo);
System.Console.WriteLine();
PrintMatrix(matrixResult);

