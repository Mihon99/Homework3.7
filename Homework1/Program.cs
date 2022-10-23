double[,] CreateArray( int m, int n)
{
    double[,] a = new double[m,n];
    for (int row = 0; row < m; row++)
    {
        for (int col = 0; col < n; col++)
        {
            a[row,col] = Convert.ToDouble(new Random().Next(-100,100)*1.0/100);
        }       
    }

    return a;
}

void PrintArray(double[,] array)
{
    for (int row = 0; row < array.GetLength(0); row++)
    {
        for (int col = 0; col < array.GetLength(1); col++)
        {
            Console.Write($"{array[row,col]} ");
        }

        Console.WriteLine();
    }
}

int m = PrintAndGetValue("Чему равно количество строк");
int n = PrintAndGetValue("Чему равно количество стобцов");
double[,] array = CreateArray(m,n);
PrintArray(array);

int PrintAndGetValue(string message)
{
    Console.WriteLine(message);
    int input = int.Parse(Console.ReadLine());
    return input;
}