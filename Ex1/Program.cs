// Задача 54: Задайте двумерный массив. Напишите программу, 
//которая упорядочит по убыванию элементы каждой строки двумерного массива.
int[,] GetMatrix(int rows, int cols, int minValue, int maxValue)
{
    int[,] matrix=new int[rows,cols];
    for(int i=0;i<matrix.GetLength(0);i++)
    {
        for(int j=0;j<matrix.GetLength(1);j++)
        {
            matrix[i,j]=new Random().Next(minValue,maxValue+1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,]matr)
{
    for(int i=0;i<matr.GetLength(0);i++)
    {
        for(int j=0;j<matr.GetLength(1);j++)
        {
            Console.Write(matr[i,j]+"\t");
        }
        Console.WriteLine();
    }
}

int[,] resultMatrix=GetMatrix(5,6,0,10);
PrintMatrix(resultMatrix);

for(int i=0;i<resultMatrix.GetLength(0);i++)
{
    for(int j=0;j<resultMatrix.GetLength(1);j++)
    {
        int temp=0;
        if()
    }
}