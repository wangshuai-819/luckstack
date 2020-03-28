using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork
{
    public class TokenManager
    {
        private int _token;
        public int  Add(int a,int b)
        {
            return a | b;
        }
        public int  Remove(int a,int b)
        {
            return a ^ b;
        }
        public int  Has(int a,int b)
        {
            return a&b;
        }

    }
    public enum Token
    {
        SuperAdmin,
        Admin,
        Blogger,
        Newbie,
        Registered,
    }
}
