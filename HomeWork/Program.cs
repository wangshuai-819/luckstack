using System;

namespace HomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            MimicStack box = new MimicStack(2);
            box.Push(1);
            box.Push(2);
            //box.Push(3);
            Console.WriteLine("--------------------");
            Console.WriteLine(box.Pop());
            Console.WriteLine(box.Pop());
            Console.WriteLine(box.Pop());
            Console.WriteLine(box.Pop());

        }
    }
}
