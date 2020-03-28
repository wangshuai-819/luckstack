using System;
using System.Collections.Generic;
using System.Text;

namespace Entity
{
    public class Content
    {
        public Content(string kind)
        {
            this.kind = kind;
        }
        protected internal string kind { get; set; }
        private DateTime _creatTime;
        public DateTime PublishTime { get; }
    }
}
