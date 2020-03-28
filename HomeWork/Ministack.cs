using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork
{
    class Ministack
    {
        public Ministack(int length)
        {
            container = new string[length];
        }
        private string[] container;
        public int top;
        public string pop()
        {
            if (top == 0 )
            {
                return "栈已空";
            }
            top--;
            return container[top];
        }

        public void Push(string value)
        {
            if (top == container.Length)
            {
                Console.WriteLine("栈溢出");
                return;
            }//else
            container[top] = value;
            Console.Write(container[top] + ",");
            top++;
        }
    }
}
 
 
