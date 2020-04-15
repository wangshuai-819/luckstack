using System;
using Entity;
using System.Reflection;
using System.Collections.Generic;
using System.Linq;

namespace LuckStack
{
    class Program
    {
        static void Main(string[] args)
        {
            User fg = new User("飞哥", "123456");
            User fish = new User("小余", "234567");
            User self = new User("自己", "345678");
            User wait = new User("等待", "45678");
            IEnumerable<User> users = new List<User> { fg, fish, self, wait };

            Keyword csharp = new Keyword { Word = "C#"    };
            Keyword java = new Keyword { Word = "java" };
            Keyword SQL = new Keyword { Word = "sql " };
            Keyword UI = new Keyword { Word = "UI" };
            Keyword NET = new Keyword { Word = ".Net " };
            IEnumerable<Keyword> keywords = new List<Keyword> { csharp, java, SQL, UI, NET };

            Comment excellent = new Comment { Word = "666" };
            Comment good = new Comment { Word = "66" };
            Comment common = new Comment { Word = " 一般" };
            Comment bad = new Comment { Word = "糟透了" };
            IEnumerable<Comment> comments = new List<Comment> { excellent, good, common, bad };

            Article HTML = new Article
            {
                Comments = new List<Comment> { excellent, good, common },
                Keywords = new List<Keyword> { csharp, java, SQL, NET },
                Author = fg,
                Title = "html"
            };
            Article JavaScript = new Article
            {
                Comments = new List<Comment> { excellent, good, common, bad },
                Keywords = new List<Keyword> { csharp, java, SQL },
                Author = fg,
                Title = "javascript"
            };
            Article Python = new Article
            {
                Comments = new List<Comment> { excellent, good, common },
                Keywords = new List<Keyword> {     SQL  },
                Author = fg,
                Title = "python"
            };
            Article Linux = new Article
            {
                Comments = new List<Comment> { good, common },
                Keywords = new List<Keyword> { csharp, SQL },
                Author = fish,
                Title = "linux"
            };
            IEnumerable<Article> articles = new List<Article> { HTML, Linux, JavaScript,Python };

            csharp.Articles = new List<Article> { HTML, JavaScript };
            excellent.Article =  HTML;

            var articlebyfg = from a in articles
                              where a.Author.Name == "飞哥"
                              select a;
            var articlebyfgl = articles.Where(a => a.Author.Name == "飞哥");

            var articlebyfish = from a in articles
                                where a.Author.Name == "小鱼" && a.CreatTime > new DateTime(2019, 1, 1)
                                select a;
            var articlebyfishl = articles.Where(a => a.Author.Name == " 小鱼").Where(t => t.CreatTime > new DateTime(2019, 1, 1));

            var articledes = from a in articles
                             orderby a.CreatTime
                             select a;
            var articledesl = articles.OrderByDescending(a => a.CreatTime);

            var authorcount = from a in articles
                              group a by a.Author into aa
                              select new
                              {
                                  authorname=aa.Key,
                                  count=aa.Count(),
                              };
            var authorcountl = articles.GroupBy(a => a.Author)
                .Select(aa => new { author = aa.Key, count = aa.Count() }
                );

            var keywordcon = from a in articles
                             where a.Keywords.Contains(csharp) || a.Keywords.Contains(NET)
                             select a;

           
                            


            #region creattime  反射
            Content content = new Content();
            ChangecreatTime(content, DateTime.Now);
            #endregion


            #region 特性+反射
            Content article = new Article();
            IsHelpMoneyChanged(article);

            #endregion


        }
        static void IsHelpMoneyChanged(Object obj)
        {
            if (HelpMoneyChangedAttribute.IsDefined(typeof(Object).GetMethod("Publish"), typeof(HelpMoneyChangedAttribute), false))
            {
                //HelpMoneyChangedAttribute.GetCustomAttribute(  );
                //HelpMoneyChangedAttribute change = attributeonatricle as HelpMoneyChangedAttribute;
                //Console.WriteLine(change.Message);
            }

        }
        static void ChangecreatTime(Content content, DateTime dateTime)
        {
            Type typeInfo = typeof(Content);
            PropertyInfo property = typeInfo.GetProperty("CreatTime", BindingFlags.Public | BindingFlags.Instance);
            //property.SetValue(content,  DateTime.Now);

        }
    }

}
