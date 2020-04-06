using System;
using System.Collections.Generic;
using System.Text;

namespace Entity
{
    public class Article : Content  
    {
        public Article() : base("article")
        {

        }
        public IList<Comment> Comments { get; set; }
        public Appraise Appraise { get; set; }
        public IList<Keyword> Keywords { get; set; }
        public User Author { get; set; }
        public string Title
        {
            get => Title;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    Console.WriteLine("标题不能为null值，也不能为一个或多个空字符组成的字符串");
                }
                value = value.Trim();
                Title = value;
            }
        }
        //public string[] Keywords { get; set; }
        //public string[] Comments { get; set; }
        [HelpMoneyChanged(25, Message = " 发布")]
        public override void Publish()
        {
            base.Publish();
            //Author.helpMoney--;
        }
        public void Agree(User voter)
        {
            Author.HelpCredit++;
            voter.HelpBean--;
        }
        public void Disagree(User user)
        {
            Author.HelpCredit++;
            user.HelpBean--;
        }
    }
}
