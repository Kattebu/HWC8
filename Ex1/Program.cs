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

int[,] resultMatrix=GetMatrix(3,4,0,10);
Console.WriteLine("исходный массив: ");
PrintMatrix(resultMatrix);
Console.WriteLine();

int i =1;
int temp=resultMatrix[i,0];
for (int j=1; j<resultMatrix.Length-1;j++)
{
    if(resultMatrix[i,j]>resultMatrix[i,j-1])
    {
        temp=resultMatrix[i,j-1];
        resultMatrix[i,j-1]=resultMatrix[i,j];
        resultMatrix[i,j]=resultMatrix[i,j-1];
    }
}
int i =2;
int temp=resultMatrix[i,0];
for (int j=1; j<resultMatrix.Length-1;j++)
{
    if(resultMatrix[i,j]>resultMatrix[i,j-1])
    {
        temp=resultMatrix[i,j-1];
        resultMatrix[i,j-1]=resultMatrix[i,j];
        resultMatrix[i,j]=resultMatrix[i,j-1];
    }
}
/*for(int i=0;i<resultMatrix.Length;i++)
{
    int temp=resultMatrix[i,0];
    for(int j=0;j<resultMatrix.Length-1;j++)
    {
        if(resultMatrix[i,j]>resultMatrix[i,j+1])
        {
            temp=resultMatrix[i,j];
            resultMatrix[i,j]=resultMatrix[i,j+1];
            resultMatrix[i,j+1]=temp;
        }
    }
}
PrintMatrix(resultMatrix);*/