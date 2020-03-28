using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork
{
    class MimicStack
    {
        public MimicStack(int length)
        {
            container = new int[length];
        }
        private int[] container;
        public int top;
        public int  Pop (/*out empty*/)
        {
            if (top==0)
            {
                Console.WriteLine("栈已空");
                return -1;
            }
                top--;
            return container[top];
        }
            
        public void Push(int value)
        {
            if (top==container.Length)
            {
                Console.WriteLine("栈溢出");
                return;
            }//else
            container[top] = value;
            Console.Write (container[top] + ",");
            top++;
        }
    }
}
