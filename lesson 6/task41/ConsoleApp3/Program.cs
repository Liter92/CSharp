internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Введите числа через запятую: ");
        int[] numbers = StringToNum(Console.ReadLine());
        PrintArray(numbers);
        int sum = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] > 0)
            {
                sum++;
            }
        }

        int[] StringToNum(string input)
        {
            int count = 1;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == ',')
                {
                    count++;
                }
            }

            int[] numbers = new int[count];
            int index = 0;

            for (int i = 0; i < input.Length; i++)
            {
                string temp = "";
                try
                {

                    while (input[i] != ',')
                    {
                        if (i == input.Length - 1)
                        {

                            temp += input[i].ToString();
                            break;
                        }
                        else
                        {
                            temp += input[i].ToString();
                            i++;
                        }
                    }
                    numbers[index] = Convert.ToInt32(temp);
                    index++;
                    

                }
                catch (FormatException)
                {                   
                    Console.WriteLine("Проверьте вводимые данные!");
                    break;
                }
              
            }
            return numbers;
        }

        Console.WriteLine();
        Console.WriteLine($"кол-во чисел >0 = {sum}");
        void PrintArray(int[] array)
        {
            Console.Write("| ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + ",");
            }
            Console.Write("|");

        }
    }
}