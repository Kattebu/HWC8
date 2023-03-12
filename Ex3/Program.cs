// Задача 58: Задайте две матрицы.
// Напишите программу, которая будет находить произведение двух матриц.
Console.WriteLine("Введите размер матриц: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальное значение элементов: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное значение элементов: ");
int max = Convert.ToInt32(Console.ReadLine());
int[,] GetMatrix (int rows, int cols,int min,int max)
{
    int[,] matrix =new int[rows,cols];
    for(int i=0;i<rows;i++)
    {
        for(int j=0; j<cols;j++)
        {
            matrix[i,j]=new Random().Next(min,max+1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] inputMatrix)
{
    for(int i=0;i<inputMatrix.GetLength(0);i++)
    {
        for(int j=0;j<inputMatrix.GetLength(1);j++)
        {
            Console.Write(inputMatrix[i,j]+"\t");
        }
        Console.WriteLine();
    }
}

int[,] firstMatrix=GetMatrix(x,x,min,max);
PrintMatrix(firstMatrix);
Console.WriteLine();
int[,] secondMatrix=GetMatrix(x,x,min,max);
PrintMatrix(secondMatrix);
Console.WriteLine();
/// <summary>
/// находим произведение матриц
/// </summary>
int[,] resultMatrix=new int[x,x];
for(int i=0;i<resultMatrix.GetLength(0);i++)
    {
        for(int j=0;j<resultMatrix.GetLength(1);j++)
        {
            int sum=0;
            for(int n=0;n<firstMatrix.GetLength(1);n++)
            {
                sum+=firstMatrix[i,n]*secondMatrix[n,j];
            }
            resultMatrix[i,j]=sum;
        }
    }
  PrintMatrix(resultMatrix);  