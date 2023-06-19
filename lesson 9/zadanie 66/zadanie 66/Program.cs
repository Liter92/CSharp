Console.WriteLine("Введите число m:");
int numbrm = int.Parse(Console.ReadLine());
Console.WriteLine("Введите коненчное число n:");
int numbrn = int.Parse(Console.ReadLine());
if (numbrm<0 || numbrn<0) 
    Console.WriteLine("введите положительные значения");

else
{ 
///Метод нахождения суммы натуральных элементов в промежутке от M до N
void sumelem(int numberM, int numberN, int sum)
{
    if (numberM > numberN)
    {
        Console.WriteLine($"Сумма натуральных элементов в промежутке от M до N: {sum}");
        return;
    }
    sum = sum + (numberM++);
    sumelem(numberM, numberN, sum);
}

sumelem(numbrm, numbrn, 0);
   
}
