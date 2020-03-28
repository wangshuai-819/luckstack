using System;
using Entity;
 

namespace LuckStack
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 封装的练习
            Console.WriteLine("Hello World!");
            User xx = new User("轩轩", 25)
            {
                Name = "admin",
            };
            Console.WriteLine(xx.Name + ",");
            Problem help = new Problem("主题")
            {
                Reward = 25
            };
            Console.WriteLine(help.Body  + "," + help.Reward);
            #endregion

            //Content content = new Content("kind");
            //Console.WriteLine(content.kind);
            //Article article = new Article();
            //Console.WriteLine(article.kind);

        }
    }
}
