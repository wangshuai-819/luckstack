using System;
using System.Collections.Generic;
using System.Text;

namespace Entity
{
    class Problem
    {
        private string _author;
        private string _title;
        private string _body;
        private int _reward;
        private DateTime _publishDateTime;
        public DateTime Publish()
        {
            return _publishDateTime;
        }
    }
}
