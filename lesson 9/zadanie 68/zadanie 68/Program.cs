Console.WriteLine("Введите число m:");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число n:");
int n = int.Parse(Console.ReadLine());
if (n < 0 || m < 0)
    Console.WriteLine("введите положительные значения");
else
{
    int functionAkkerman = Ack(m, n);

    Console.Write($"Функция Аккермана = {functionAkkerman} ");

    int Ack(int m, int n)
    {
        if (m == 0) return n + 1;
        else if (n == 0) return Ack(m - 1, 1);
        else return Ack(m - 1, Ack(m, n - 1));
    }

}