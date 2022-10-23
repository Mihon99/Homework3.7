int m = PrintAndGetValue("Чему равно количество строк");
int n = PrintAndGetValue("Чему равно количество стобцов");
int[,] array = CreateArray(m,n);
PrintArray(array);
Sum(array);

void Sum(int[,] array)
{
    double summ = 0;
      
    double[] result = new double[n];
    Console.Write("Среднее арифметическое в столбцах = [");
    for (int col = 0; col < array.GetLength(1); col++)            
    {
        double sum = 0;
        for (int row = 0; row < array.GetLength(0); row++)
        {
            sum = sum + array[row,col];
            summ = sum / m;                     
        }
                    
        Console.Write($"{Math.Round(summ,2)};");
    }
    Console.Write("]");  
}

int[,] CreateArray( int m, int n)
{
    int[,] a = new int[m,n];
    for (int row = 0; row < m; row++)
    {
        for (int col = 0; col < n; col++)
        {
            a[row,col] = new Random().Next(1,10);
        }       
    }

    return a;

}

void PrintArray(int[,] array)
{
    Console.WriteLine();
    for (int row = 0; row < array.GetLength(0); row++)
    {
        for (int col = 0; col < array.GetLength(1); col++)
        {
            Console.Write($"{array[row,col]} ");
        }

        Console.WriteLine();
    }
    Console.WriteLine();
}

int PrintAndGetValue(string message)
{
    Console.WriteLine(message);
    int input = int.Parse(Console.ReadLine());
    return input;
}

/*double sum = 0;
int[,] arr = new int[new Random().Next(1, 10), new Random().Next(1, 10)];
for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j ++)
    {
        arr[i, j] = new Random().Next(1, 10);
        Console.Write(arr[i, j] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine("---------------------------");
Console.WriteLine(arr.GetLength(0));
for (int j = 0; j < arr.GetLength(1); j ++)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        sum  += arr [i, j];
    }
    Console.Write($"{sum / arr.GetLength(0)} ");
}
Console.ReadLine();*/