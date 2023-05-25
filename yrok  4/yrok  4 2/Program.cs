using System;
using System.Globalization;
using System.Linq;
using System.Reflection.Metadata;
class Program
{
    public static int Main()
    {
        string a1 = ("Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.\n");
        string z2 = ("\nНапишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.\n");
        string z3 = ("\nНапишите программу, которая задаёт массив из 8 элементов и выводит их на экран.\n");



        Console.Write(a1 + " число А: ");
        int A1 = Convert.ToInt32(Console.ReadLine());
        Console.Write(" число B: ");
        int B1 = Convert.ToInt32(Console.ReadLine());

        int result = 1;
        for (int z = 0; z < B1; z++)
        {
            result *= A1;

        }
        Console.WriteLine("число в степени: {0}", result);




        Console.Write(z2 + "Введите число N: ");
        int numberN = Convert.ToInt32(Console.ReadLine());

        int SumNumber(int nka)
        {

            int counter = Convert.ToString(nka).Length;
            int advan = 0;
            int rs = 0;

            for (int i = 0; i < counter; i++)
            {
                advan = nka - nka % 10;
                rs = rs + (nka - advan);
                nka = nka / 10;
            }
            return rs;
        }

        int sumNumber = SumNumber(numberN);
        Console.WriteLine("Сумма цифр в числе: " + sumNumber);


        Console.WriteLine(z3);
        int[] numbers = new int[8];
     

        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = new Random().Next(0, 11);
            Console.Write(" " + Method(i) + " ");
        }
       

        int Method(int a)
        {
            return numbers[a];
        }
        return 0;

    }
}
