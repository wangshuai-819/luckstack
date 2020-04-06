using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork
{
    public class TokenManager
    {
        private int _tokens;
        public int  Add(int token)
        {
            _tokens= _tokens | token;
            return _tokens;
        }
        public int  Remove(int token)
        {
            _tokens = _tokens ^ token;
            return _tokens;
        }
        public int  Has(int token)
        {
            _tokens = _tokens & token;
            return _tokens;
        }

    }
    public enum Token
    {
        SuperAdmin=1,
        Admin=2,
        Blogger=4,
        Newbie=8,
        Registered=16,
    }
}
