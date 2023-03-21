// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу 
//кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

internal partial class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Введите целое число: ");
        int num = Convert.ToInt32(Console.ReadLine());
        Cub(num); //вызов функции



        void Cub(int num) //функция
        {
            int n = 0;
            for (int i = 1; i <= num; i++)
            {
                n = i * i * i;
                Console.Write(n + " ");
            }

        }
    }
}