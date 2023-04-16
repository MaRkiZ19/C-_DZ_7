//Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

int Num (string arg)
{
    System.Console.WriteLine($"Введите {arg} ");
    return int.Parse(System.Console.ReadLine());
}

int n = Num("n");
int m = Num("m");

int[,] matrix = new int[m,n];

void FillArray (int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matr[i,j]=new Random().Next();
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