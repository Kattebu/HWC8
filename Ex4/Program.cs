// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите 
// программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Console.WriteLine("Введите размер массива по оси x: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите размер массива по оси y: ");
int y = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите размер массива по оси z: ");
int z = Convert.ToInt32(Console.ReadLine());
/// <summary>
/// Сформировать трехмерный массив из неповторяющихся элементов
/// </summary>
/// <param name="array3">трехмерный массив из неповторяющихся элементов</param>
void GetArray (int [,,] array3)
{
    int[] tempArray =new int[array3.GetLength(0)*array3.GetLength(1)*array3.GetLength(2)];
    int number;
    for(int i=0;i<tempArray.GetLength(0);i++)
    {
        tempArray[i]=new Random().Next(10,100);
        number=tempArray[i];
        if(i>0)
        {
           for(int j=0; j<i;j++) 
           {
            while(tempArray[i]==tempArray[j])
            {
                tempArray[i]=new Random().Next(10,100);
                j=0;
                number=tempArray[i];
            }
            number=tempArray[i];
           }
        }
    }
    int count=0;
    for(int x=0;x<array3.GetLength(0);x++)
    {
        for(int y=0;y<array3.GetLength(1);y++)
        {
            for(int z=0;z<array3.GetLength(2);z++)
            {
                array3[x,y,z]=tempArray[count];
                count++;
            }
        }
    }
}

void PrintArray(int[,,] inputMatrix)
{
    for(int i=0;i<inputMatrix.GetLength(0);i++)
    {
        for(int j=0;j<inputMatrix.GetLength(1);j++)
        {
            for(int n=0; n<inputMatrix.GetLength(2); n++)
            {
            Console.Write(inputMatrix[i,j,n]+"("+i+","+j+","+n+")"+"\t");
            }
            Console.WriteLine();
        }
    }
}
int[,,]array3=new int[x,y,z];
GetArray(array3);
PrintArray(array3);