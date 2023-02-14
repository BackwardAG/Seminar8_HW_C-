// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт 
// номер строки с наименьшей суммой элементов: 1 строка


int[,] FillMatrix(int rows, int cols)
{
    Random rand = new Random();
    int[,] matr = new int[rows, cols];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            matr[i, j] = rand.Next(1, 10);
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


int SumRow(int[,] matrix, int i)
{
    int sumRow = matrix[i, 0];
    for (int j = 1; j < matrix.GetLength(1); j++)
    {
        sumRow += matrix[i, j];
    }
    return sumRow;
}


int[,] matrix = FillMatrix(3, 4);
PrintMatrix(matrix);

int sumMin = 0;
int sumRow = SumRow(matrix, 0);

for (int i = 0; i < matrix.GetLength(0); i++)
{
    int temp = SumRow(matrix, i);
    if (sumRow > temp)
    {
        sumRow = temp;
        sumMin = i;
    }

}
System.Console.WriteLine($"{sumMin+1} - ряд с наименьшей суммой элементов({sumRow})"); 
    
