Console.Write("Введите размерность m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите размерность n: ");
int n = Convert.ToInt32(Console.ReadLine());
if (n > 0 && m > 0)
{
    double[,] randomArray = new double[m, n];
    void ZapolnenieRand(int m, int n)
    {
        int i, V;
        Random rand = new Random();
        for (i = 0; i < m; i++)
        {
            Console.WriteLine();
            for (V = 0; V < n; V++)
            {
                randomArray[i, V] = rand.NextDouble() * 100;
                Console.Write("{0,6:F1}", randomArray[i, V]);
            }
        }
    }
    ZapolnenieRand(m, n);
}
else Console.WriteLine("Введите корректные данные");
