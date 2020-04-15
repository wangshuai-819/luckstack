using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork
{
    public class TokenManager
    {
        public Token _tokens;
        public Token Add(Token token)
        {
            _tokens= _tokens | token;
            return _tokens;
        }
        public Token Remove(Token token)
        {
            _tokens = _tokens ^ token;
            return _tokens;
        }
        public Token Has(Token token)
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
