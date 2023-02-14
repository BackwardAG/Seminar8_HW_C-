// Задача 60. 
// ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив,
// добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)



void CreateMatrix3D(int[,,] matrix3d)
{
    int[] array = new int[matrix3d.GetLength(0) * matrix3d.GetLength(1) * matrix3d.GetLength(2)];
    int temp = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        array[i] = new Random().Next(10, 100);
        temp = array[i];
        if (i >= 1)
        {
            for (int j = 0; j < i; j++)
            {
                while (array[i] == array[j])
                {
                    array[i] = new Random().Next(10, 100);
                    j = 0;
                    temp = array[i];
                }
                temp = array[i];
            }
        }
    }
    int count = 0;
    for (int x = 0; x < matrix3d.GetLength(0); x++)
    {
        for (int y = 0; y < matrix3d.GetLength(1); y++)
        {
            for (int z = 0; z < matrix3d.GetLength(2); z++)
            {
                matrix3d[x, y, z] = array[count];
                count++;
            }
        }
    }
}

void PrintMatrix3d(int[,,] matrix3d)
{
    for (int i = 0; i < matrix3d.GetLength(0); i++)
    {
        for (int j = 0; j < matrix3d.GetLength(1); j++)
        {
            
            for(int k = 0; k < matrix3d.GetLength(2); k++)
            {
                Console.Write($" {matrix3d[i,j,k]}({i},{j},{k})");

            }
            
        }
        System.Console.WriteLine();
    }
}

Console.WriteLine("Введите размеры 3D-массива X x Y x Z:");
int x = Convert.ToInt32(Console.ReadLine());
int y = Convert.ToInt32(Console.ReadLine());
int z = Convert.ToInt32(Console.ReadLine());

int[,,] matrix3d = new int[x, y, z];

System.Console.WriteLine();
CreateMatrix3D(matrix3d);
PrintMatrix3d(matrix3d);