﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Entity
{
    public class Problem
    {
        public Problem(string body)

        {
             _body = body;
        }
        //private string _author;
        public string Author { get; set; }

        //private string _title;
        public string Title { get; set; }

        private string _body;
        public string Body { get; set; }

        private int _reward;
        public int Reward
        {
            get
            {
                return _reward;
            }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Reward不能为负数");
                    return;
                }//else
                _reward = value;

            }

        }

        private DateTime _publishDateTime;
        private string[] _keyword = new string[10];
        public string this[int index]
        {
            get { return _keyword[index]; }
            set { _keyword[index] = value; }
        }
        public DateTime Publish()
        {
            Console.WriteLine("保存到数据库");
            return _publishDateTime;
        }
        public void Load(int Id)
        {
            Console.WriteLine("获取一条求助");
        }
        public void Delete(int Id)
        {
            Console.WriteLine("删除某条求助");
        }
      
    }
}
