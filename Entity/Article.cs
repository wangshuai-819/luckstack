using System;
using System.Collections.Generic;
using System.Text;

namespace Entity
{
	public class Article : Content
	{
		public Article() :base("article")
		{
		  
		}
		public User Author { get; set; }
		public string Title { get; set; }
		public string[] Keywords { get; set; }
		public string[] Comments { get; set; }
		public override void Publish()
		{
			base.Publish();
			Author.helpMoney--;
		}
		public void Agree(User voter)
		{
			Author.HelpCredit++;
			voter.HelpBean--;
		}
		public void Disagree(User user )
		{
			Author.HelpCredit++;
			  user.HelpBean--;
		}
	}
}
