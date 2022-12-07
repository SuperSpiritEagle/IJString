using System;

namespace IJString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Как вас зовут?");
            string name = Console.ReadLine();
            Console.WriteLine("Сколько вам лет");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Какой у вас знак зодиака");
            string zodiacSign = Console.ReadLine();
            Console.WriteLine("Где вы работаете");
            string placeWork = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine($"Вас зовут {name}, вам {age}, вы {zodiacSign} и работаете {placeWork}");
        }
    }
}
