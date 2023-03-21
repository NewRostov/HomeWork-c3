internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Введите не четное целое число от 3 до N: ");
        int num = Convert.ToInt32(Console.ReadLine());
        if (num < 3) Console.WriteLine("Введите число от 3 до N");
        else if (num % 2 != 0)
        {

            int[] n = new int[num];
            for (int i = 0; i < num; i++)
            {
                Console.Write($"Введите {i + 1}-е число из {num} : ");
                n[i] = Convert.ToInt32(Console.ReadLine());
            }
            PolindromCheck(num); // вызов функции





            void PolindromCheck(int num) // функция
            {
                int count = 0;

                for (int i = 0; i < num; i++)
                {
                    if (n[i] == n[num - 1 - i])
                        count++;

                }
                Console.Write("Вы ввели числа:");
                foreach (var rezult in n)
                    Console.Write(" " + rezult + " ");
                if (count == n.Length) Console.WriteLine("Комбинация чисел ЯВЛЯЕТСЯ ли палиндромом");
                else Console.WriteLine("Комбинация чисел НЕ является ли палиндромом");

            }

        }


        else Console.WriteLine("Вы ввели четное число!");
    }
}