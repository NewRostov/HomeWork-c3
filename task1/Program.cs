// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом. Через строку решать нельзя.
// 14212 -> нет
// 12821 -> да
//23432 -> да

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("введите число 1 из 5 : ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("введите число 2 из 5 ");
        int b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("введите число 3 из 5 ");
        int c = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("введите число 4 из 5 ");
        int d = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("введите число 5 из 5 ");
        int e = Convert.ToInt32(Console.ReadLine());


        PolindromCheck1(a, b, c, d, e);  // простое решение
        PolindromCheck2(a, b, c, d, e);    // цикл




        // простое решение
        void PolindromCheck1(int a, int b, int c, int d, int e)
        {

            int[] polidrom = { a, b, c, d, e };
            if (polidrom[0] == polidrom[4] && polidrom[1] == polidrom[3])
                Console.WriteLine("простое решение - число является палиндромом");
            else Console.WriteLine("простое решение - число НЕ является палиндромом");

        }

        // цикл
        void PolindromCheck2(int a, int b, int c, int d, int e)
        {

            int i = 0;
            int count = 0;
            int[] polidrom = { a, b, c, d, e };
            do
            {
                if (polidrom[i] == polidrom[polidrom.Length - 1 - i])
                    count++;
                i++;
            }
            while (i < polidrom.Length);

            if (count == polidrom.Length) Console.WriteLine("цикл - число является ли палиндромом");
            else Console.WriteLine("цикл - число НЕ является ли палиндромом");

        }
    }
}