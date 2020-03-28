using System;

namespace HomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 模拟栈  int  类型
            bool empty;
            MimicStack box = new MimicStack(2);
            box.Push(1);
            box.Push(2);
            //box.Push(3);
            Console.WriteLine("--------------------");
            Console.WriteLine(box.Pop(out empty) == 3);
            Console.WriteLine(box.Pop(out empty) == 2);
            Console.WriteLine(box.Pop(out empty) == 1);
            Console.WriteLine(!empty);
            Console.WriteLine(!empty);
            #endregion
            #region 模拟栈 string类型
            Ministack tet = new Ministack(3);
            Console.WriteLine(tet.pop());
            tet.Push("9");
            tet.Push("8");
            tet.Push("7");
            tet.Push("6");
            Console.WriteLine(tet.pop());
            Console.WriteLine(tet.pop());
            Console.WriteLine(tet.pop());
            Console.WriteLine(tet.pop());
            Console.WriteLine(tet.pop());
            #endregion

            #region dynamic和var的区别
            //dynamic a = "25";
            //Console.WriteLine(a - 23);
            //var b = "23";
            //Console.WriteLine(b - 23);
            #endregion


            Console.WriteLine(new MimicStack(1));
        }
    }
}
