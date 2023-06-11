Random random = new Random();
int[,] arr = new int[random.Next(4, 8), random.Next(4, 8)];
for (int i = 0; i < arr.GetLength(0); i++)
{
    Console.Write("|");
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        arr[i, j] = random.Next(1, 100);
        Console.Write(arr[i, j] + " ");
        

    }
    Console.Write("|");
    Console.WriteLine();
}
Console.WriteLine("\n");
Console.WriteLine("кол-во элементов в столбце: "+arr.GetLength(0));
Console.WriteLine("\nСреднее значение в каждом столбце:");

for (int j = 0; j < arr.GetLength(1); j++)
{
    double sum = 0;
 
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        sum += arr[i, j];
    }

    Console.Write($"{sum / arr.GetLength(0)} ");
  
 
}
Console.ReadKey();



