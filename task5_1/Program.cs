// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4. 
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07


int[,] FillSpiralMatrix(int row, int col)
{
    int[,] matrix = new int[row, col];
    // сужения
    int Up = 0; // сверху
    int Down = 0; // снизу
    int Left = 0; // слева
    int Right = 0; // справа

    int i = 0; // координаты строки
    int j = 0; // координаты столбца
    int k = 0; // счетчик с значениями элементов

    while(k <= row* col - 1)
    {
        matrix[i,j] = k;
        bool canMoveRight = i == Up && j < col - Right -1; 
        bool canMoveDown = j == col - Right - 1 && i < row - Down - 1;
        bool canMoveLeft = i == row - Down -1 && j > Left;
        bool isFullLaps = i == Up +1 && j == Left && Left != col - Right - 1;

        if(canMoveRight)
        {
            j++;
        }
        else if(canMoveDown)
        {
            i++;
        }
        else if (canMoveLeft)
        {
            j--;
        }
        else
        {
            i--;
        }
        if(isFullLaps)
        {
            Up++;
            Down++;
            Left++;
            Right++;
        }
        k++;
        
        
    }
    return matrix;
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

int [,] matrix = FillSpiralMatrix(4,4);
PrintMatrix(matrix);
