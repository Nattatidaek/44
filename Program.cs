using System;

namespace ConsoleApp22
{
    class Program
    {
        static void Main(string[] args)
        {
            float x,y,dx,dy step;
            Console.Write("Input X1:");
            float x1 = float.Parse(Console.ReadLine());
            Console.Write("Input X2:");
            float x2 = float.Parse(Console.ReadLine());
            Console.Write("Input Y1:");
            float y1 = float.Parse(Console.ReadLine());
            Console.Write("Input Y2:");
            float Y2 = float.Parse(Console.ReadLine());

            dx = x2 - x1;
            dy = Y2 - y1;
        }
}
