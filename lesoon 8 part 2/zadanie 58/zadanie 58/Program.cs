
int m = InputNumbers("Введите число строк 1-й матрицы: ");
int n = InputNumbers("Введите число столбцов 1-й матрицы (и строк 2-й): ");
int p = InputNumbers("Введите число столбцов 2-й матрицы: ");
int InputNumbers(string input)
{
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}

if (m!=n & n!=p & p!=n & n!=p)
{
    Console.WriteLine("\nВведите корректные даные");
}
else
{

    var R = new Random();
    int range = R.Next(1, 1000);


    int[,] firstMartrix = new int[m, n];
    CreateArray(firstMartrix);
    Console.WriteLine($"Первая матрица:");
    writearr(firstMartrix);

    int[,] secomdMartrix = new int[n, p];
    CreateArray(secomdMartrix);
    Console.WriteLine($"Вторая матрица:");
    writearr(secomdMartrix);

    int[,] resultMatrix = new int[m, p];

    MultiplyMatrix(firstMartrix, secomdMartrix, resultMatrix);
    Console.WriteLine($"Произведение первой и второй матриц:");
    writearr(resultMatrix);

    void MultiplyMatrix(int[,] firstMartrix, int[,] secomdMartrix, int[,] resultMatrix)
    {
        for (int i = 0; i < resultMatrix.GetLength(0); i++)
        {
            for (int j = 0; j < resultMatrix.GetLength(1); j++)
            {
                int sum = 0;
                for (int k = 0; k < firstMartrix.GetLength(1); k++)
                {
                    sum += firstMartrix[i, k] * secomdMartrix[k, j];
                }
                resultMatrix[i, j] = sum;
            }
        }
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

}