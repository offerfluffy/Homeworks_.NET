namespace Homework_1
{
    using System;
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter price of pens:");
            int x = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter price of copybooks:");
            int y = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter AMOUT of pens:");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter AMOUT of copybooks:");
            int m = int.Parse(Console.ReadLine());

            int sum = (n * x) + (m * y);

            Console.WriteLine($"Total Price: {sum}");
        }
    }
}
