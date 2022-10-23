int[] arr = GetArray("Введите значения позиции числа в массиве через пробел, сначала строку, потом столбец: ");
int m = PrintAndGetValue("Чему равно количество строк");
int n = PrintAndGetValue("Чему равно количество стобцов");
int[,] array = CreateArray(m,n);
PrintArray(array);
int answer = Answer(array,arr);
Result(answer);


void Result(int a)
{
    if (a == 0)
    {
        Console.WriteLine("Такого числа нет");
    }
    else
    {
        Console.WriteLine("Ваш запрос = " + a);
    }
}

int Answer(int[,] array, int[] arr)
{
    int a = arr[0] - 1;
    int b = arr[1] - 1;
    int number = 0;
    for (int row = 0; row < array.GetLength(0); row++)
    {
        if(row == a)          
        {                  
            for (int col = 0; col < array.GetLength(1); col++)
            {
                if (col == b)
                {
                    number = array[a,b];
                }
            }
        }              
    }
    return number;
}

int[] GetArray(string message)
{
    Console.WriteLine(message);
    string getArray = Console.ReadLine();
    string[] array = getArray.Split(" ", StringSplitOptions.RemoveEmptyEntries);
    int[] inputArray = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        inputArray[i] = int.Parse(array[i]);
    }
    return inputArray;
}

int[,] CreateArray( int m, int n)
{
    int[,] a = new int[m,n];
    for (int row = 0; row < m; row++)
    {
        for (int col = 0; col < n; col++)
        {
            a[row,col] = new Random().Next(1,100);
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