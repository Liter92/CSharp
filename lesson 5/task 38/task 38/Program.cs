Console.WriteLine("\n\nЗадание 38 №\nВведите размер массива");
int N = Convert.ToInt32(Console.ReadLine());
if (N < 2)
{
    Console.WriteLine("Ошибка, Введите положительные значения");
}
else
{
      int[] array = new int[N];
    int min = int.MaxValue;
    int max = int.MinValue;
    Random random = new Random();
    int a = 0;
    for (int i = 0; i < array.Length; i++)
    {
        ArayRandom(array, a);
        a = random.Next(-100, 100);
        array[i] = a;
        if (array[i] < min)
        {
            min = array[i];
        }
        if (array[i] > max)
        {
            max = array[i];
        }
    }
    dfd(array);
    Console.WriteLine($"Минимальное значение: {min}");
    Console.WriteLine($"Максимальное значение: {max}");
    int difference = max - min;
    Console.WriteLine($"Разница между самым большим и самым маленьким значением: {difference}");

    Console.ReadLine();


    static bool ArayRandom(int[] array, int a)
    {
        return false;
    }

    void dfd(int[] array)
    {
        Console.Write("|");
        for (int i = 0; i < array.Length; i++)

        {
            Console.Write(array[i] + ", ");
        }
        Console.Write("|\n");

    }
}