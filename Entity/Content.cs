using System;
using System.Collections.Generic;
using System.Text;

namespace Entity
{
    public class Content 
    {
        public Content( )
        {
           CreatTime = new DateTime() ;
           PublishTime = new DateTime() ;
        }
        public Content(string kind):this()
        {
            this.kind = kind;
        }
       /* public*/ protected internal string kind { get; set; }
       public DateTime CreatTime { get; }
        public DateTime PublishTime {  get; }
         
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
