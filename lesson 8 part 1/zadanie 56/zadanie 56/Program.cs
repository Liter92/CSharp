Console.WriteLine("Введите размер массива m x n и диапазон случайных значений:");
int m = intnumbr("Введите m: ");
int n = intnumbr("Введите n: ");
var R = new Random();
int range = R.Next(1, 1000);

int[,] array = new int[m, n];
CreateArray(array);
writearr(array);

int minSumLine = 0;
int sum = summet(array, 0);
for (int i = 1; i < array.GetLength(0); i++)
{
    int tempSumLine = summet(array, i);
    if (sum > tempSumLine)
    {
        sum = tempSumLine;
        minSumLine = i;
    }
}

Console.WriteLine($"\n{minSumLine + 1} - строкa является наименьшей ({sum}) элементов ");


int summet(int[,] array, int i)
{
    int sumLine = array[i, 0];
    for (int j = 1; j < array.GetLength(1); j++)
    {
        sumLine += array[i, j];
    }
    return sumLine;
}

int intnumbr(string input)
{
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}

void CreateArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(range);
        }
    }
}

void writearr(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.Write("|");
        Console.WriteLine();

    }
}

