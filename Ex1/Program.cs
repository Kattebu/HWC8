// Задача 54: Задайте двумерный массив. Напишите программу, 
//которая упорядочит по убыванию элементы каждой строки двумерного массива.
Console.WriteLine("Введите количество строк: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов: ");
int y = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите диапазон от 0 до M: ");
int max = Convert.ToInt32(Console.ReadLine());

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

int[,] firstMatrix=GetMatrix(3,x,0,max);
Console.WriteLine("исходный массив: ");
PrintMatrix(firstMatrix);
Console.WriteLine("отсортированный массив: ");
SortedArray(firstMatrix);
PrintMatrix(firstMatrix);
/// <summary>
/// сортируем строки по убыванию
/// </summary>
void SortedArray(int[,]array)
{
    for(int i=0;i<array.GetLength(0);i++)
    {
        for(int j=0;j<array.GetLength(1);j++)
        {  
            for(int n=0;n<array.GetLength(1)-1;n++)
            {
                if(array[i,n]<array[i,n+1])
                {
                    int temp=array[i,n+1];
                    array[i,n+1]=array[i,n];
                    array[i,n]=temp;
                }
            }
        }
    }
}
