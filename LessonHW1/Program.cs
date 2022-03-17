using System;

namespace LessonHW1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Чтоб найти площадь треугольника:");
            Console.WriteLine("Введите значение первой стороны:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите значение второй стороны:");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите значение третьей стороны:");
            int c = int.Parse(Console.ReadLine());

            int p = (a + b + c) / 2;

            var s = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            Console.WriteLine($"Площадь треугольника равна: {s} см2");
            Console.ReadLine();

        }
    }
}
