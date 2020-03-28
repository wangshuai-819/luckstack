using System;
using System.Collections.Generic;
using System.Text;

namespace Entity
{
    class ContentService
    {
        public void Publish(Content content)
        {
            content.Publish();
            Console.WriteLine("保存至数据库");
        }
    }
}
