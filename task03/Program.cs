//Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

int Num (string arg)
{
    System.Console.WriteLine($"Введите {arg} ");
    return int.Parse(System.Console.ReadLine());
}

int n = Num("n столбцов");
int m = Num("m строк");

int[,] matrix = new int[m,n];

void FillArray (int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matr[i,j]=new Random().Next(1,100);
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
int Length = n-1;
double number = 0;
double [] numbers = new double [Length];
for (int a = 0; a < numbers.Length; a++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
            {
             number = number + matrix[i , j];
            }
numbers[a] = number/m;
    }
}
System.Console.WriteLine(numbers);




