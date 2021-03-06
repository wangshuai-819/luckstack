﻿using System;
using Entity;
using System.Reflection;
using System.Collections.Generic;
using System.Linq;

namespace LuckStack
{
    class Program
    {
        public class Person
        {

        }
        public delegate int ProviderWater(Person person);
        public static int Water(Person person)
        {
            return 25;
        }
        public int GetWater(ProviderWater providerWater)
        {
            return providerWater(new Person());
        }
        static void Main(string[] args)
        {
            ProviderWater providerWater = delegate (Person person)
            {
                return 25;
            };
            Func<Person, int> func = person => 25;
            #region 练习
            User fg = new User("飞哥", "123456");
            User fish = new User("小余", "234567");
            User self = new User("自己", "345678");
            User wait = new User("等待", "456789");
            IEnumerable<User> users = new List<User> { fg, fish, self, wait };

            Keyword csharp = new Keyword { Word = "C#" };
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
                Title = "html",
                PublishTime=new DateTime(2020,1,1)
            };
            Article JavaScript = new Article
            {
                Comments = new List<Comment> { excellent, good, common, bad },
                Keywords = new List<Keyword> { csharp, java, SQL },
                Author = fg,
                Title = "javascript",
                PublishTime = new DateTime(2020, 3, 20)

            };
            Article Python = new Article
            {
                Comments = new List<Comment> { excellent, good, common },
                Keywords = new List<Keyword> { SQL },
                Author = fg,
                Title = "python",
                PublishTime = new DateTime(2020, 2, 18)

            };
            Article Linux = new Article
            {
                Comments = new List<Comment> { good, common },
                Keywords = new List<Keyword> { csharp, SQL },
                Author = fish,
                Title = "linux",
                PublishTime = new DateTime(2020, 4, 1)
            };
            IEnumerable<Article> articles = new List<Article> { HTML, Linux, JavaScript, Python };

            csharp.Articles = new List<Article> { HTML, JavaScript };
            excellent.Article = HTML;

            var articlebyfg = from a in articles
                              where a.Author.Name == "飞哥"
                              select a;
            var articlebyfgl = articles.Where(a => a.Author.Name == "飞哥");

            var articlebyfish = from a in articles
                                where a.Author.Name == "小鱼" && a.CreatTime > new DateTime(2019, 1, 1)
                                select a;
            var articlebyfishl = articles.Where(a => a.Author.Name == " 小鱼").Where(t => t.CreatTime > new DateTime(2019, 1, 1));

            var articledes = from a in articles
                             orderby a.PublishTime
                             select a;
            var articledesl = articles.OrderByDescending(a => a.PublishTime);

            var authorcount = from a in articles
                              group a by a.Author into aa
                              select new
                              {
                                  authorname = aa.Key,
                                  count = aa.Count(),
                              };
            var authorcountl = articles.GroupBy(a => a.Author)
                .Select(aa => new { author = aa.Key, count = aa.Count() }
                );

            var keywordcon = from a in articles
                             where a.Keywords.Contains(csharp) || a.Keywords.Contains(NET)
                             select a;
            //var keywaordjion=from a in articles
            //                 join k in keywords
            //                 on  a.Keywords
            //                 where 
            var keywordconl = articles.Select(a => a.Keywords.Contains(csharp));

            var commentmax = from a in articles
                             where a.Comments.Count > a.Comments.Count
                             select a;
            var commentmaxl = articles.OrderBy(a => a.Comments.Count()).First();
            var authorcomment = from a in articles
                                group a by a.Author into aa
                                select new
                                {
                                    authorname = aa.Key.Name,
                                    maxcomment = aa.OrderBy(aa => aa.Comments.Count()).First(),
                                };
            var publishtimeari = from a in articles
                                 orderby a.PublishTime
                                 group a by a.Author into ap
                                 select new
                                 {
                                     authorname = ap.Key.Name,
                                     rencentariticle = ap.OrderBy(aa => aa.PublishTime).Last()
                                 };
            
                                 

                              
            #endregion



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
            //if (HelpMoneyChangedAttribute.IsDefined(typeof(Object).GetMethod("Publish"), typeof(HelpMoneyChangedAttribute), false))
            //{
            //    //HelpMoneyChangedAttribute.GetCustomAttribute(  );
            //    //HelpMoneyChangedAttribute change = attributeonatricle as HelpMoneyChangedAttribute;
            //    //Console.WriteLine(change.Message);
            //}

        }
        static void ChangecreatTime(Content content, DateTime dateTime)
        {
            Type typeInfo = typeof(Content);
            PropertyInfo property = typeInfo.GetProperty("CreatTime", BindingFlags.Public | BindingFlags.Instance);
            //property.SetValue(content,  DateTime.Now);

        }
    }

}
