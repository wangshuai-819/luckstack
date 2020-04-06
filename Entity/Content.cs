using System;
using System.Collections.Generic;
using System.Text;

namespace Entity
{
    public class Content 
    {
        public Content()
        {
            _creatTime = DateTime.Now;
        }
        public Content(string kind):this()
        {
            this.kind = kind;
        }
       /* public*/ protected internal string kind { get; set; }
        private DateTime _creatTime;
        public DateTime PublishTime
        { 
            get { return _creatTime; }
        }
        [HelpMoneyChanged(25,Message =" 发布")]
        public  virtual void Publish()
        {

        }
    }
    public class EmailMessage : ISendMessage, IChat
    {
         void ISendMessage.Send()
        {
            Console.WriteLine();
        }
          void IChat.Send()
        {
            Console.WriteLine();
        }
    }
    public class DBMessage : ISendMessage, IChat
    {
        void ISendMessage.Send()
        {
            Console.WriteLine();
        }
        void IChat.Send()
        {
            Console.WriteLine();
        }
    }
    public interface ISendMessage
    {
        public void Send();
    }
    public interface IChat
    {
        public void Send();
    }

}
