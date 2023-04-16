//Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.

int Num (string arg)
{
    System.Console.WriteLine($"Введите {arg} ");
    return int.Parse(System.Console.ReadLine());
}

int n = Num("количество столбцов");
int m = Num("количество строк");

int[,] matrix = new int[m,n];

void FillArray (int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matr[i,j]=new Random().Next(-100, 100);
        }
    }
}

void PrintArray(int [,] matr)
{
for (int i = 0; i < matrix.GetLength(0); i++) 
{  
    for (int j = 0; j < matrix.GetLength(1); j++)   
    {
        System.Console.Write($"{matrix[i,j]}; "); 
    }
    System.Console.WriteLine();
}
}


System.Console.WriteLine();
FillArray(matrix);
PrintArray(matrix);
System.Console.WriteLine();
int PosColumn = Num("номер столбца") -1;
int PosString = Num("номер строки") -1;
if(PosColumn>n || PosString>m) System.Console.WriteLine("введены неверные координаты искомой ячейки");
else Console.WriteLine(matrix[PosString, PosColumn]);

