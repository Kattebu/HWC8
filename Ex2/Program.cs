// Задача 56: Задайте прямоугольный двумерный массив.
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Console.WriteLine("Введите количество строк: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов: ");
int y = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите диапазон от 0 до M: ");
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

int[,] resultMatrix=GetMatrix(x,y,0,max);
PrintMatrix(resultMatrix);

int minSumRow=0;
int sumRow=SumRowElements(resultMatrix,0);
for(int i=0;i<resultMatrix.GetLength(0);i++)
{
    int temp=SumRowElements(resultMatrix,i);
    if(sumRow>temp)
    {
        minSumRow=i;
    }
}
Console.WriteLine($"строка с наименьшей суммой под номером: {minSumRow+1}");
int SumRowElements(int[,]array,int i)
{
    int sumRow=array[i,0];
    for (int j=0;j<array.GetLength(1);j++)
    {
        sumRow+=array[i,j];
    }
    return sumRow;
}
