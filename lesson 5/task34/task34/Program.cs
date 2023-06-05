Console.WriteLine("\n\nЗадание 36 №\nВведите размер массива");
int s1 = Convert.ToInt32(Console.ReadLine());
if (s1 < 1)
{
    Console.WriteLine("Ошибка, Введите положительные значения");
}
else
{

    int[] arr = new int[s1];
    zapolnenie(arr);
    Console.WriteLine("Вот наш массив: ");
    vivod(arr);
    int sum = 0;

    for (int z = 0; z < arr.Length; z += 2)
        sum = sum + arr[z];

    Console.WriteLine($"всего {arr.Length} чисел, сумма элементов на нечётных позициях = {sum}");

    void zapolnenie(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = new Random().Next(1, 999);
        }
    }
    void vivod(int[] arr)
    {
        Console.Write("|");
        for (int i = 0; i < arr.Length; i++)

        {
            Console.Write(arr[i] + ", ");
        }
        Console.Write("|\n");

    }
}
