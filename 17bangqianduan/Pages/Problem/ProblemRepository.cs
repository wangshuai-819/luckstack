using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _17bangqianduan.Pages.Problem
{
    public class ProblemRepository
    {
        private static IList<ProblemModel> _problemModel;
        static ProblemRepository()
        {
            _problemModel = new List<ProblemModel>
            {
                new ProblemModel
                {
                    PublishTime=DateTime.Now,
                    Author=new UserModel{Name=" M...",Id=1},
                    Title=" 额，怎么说，看下吧，谢谢了{》=《}，我只有五个帮币，呜呜",
                    Abstract="java语言写的代码需要先编译为可执行文件，才能被jvm执行。在下载的jdk安装目录下的bin目录，有两个可执行程序java.exe和javac.exe，javac就是用来编译的，java是执行编译后的class文件。刚写好的java程序是.java结尾的文件，需要经过编译，变为.class结尾的文件，然后交给虚拟机执行。新建一个HelloWorld.java文件，将以下代码贴入：public class HelloWorld { public static void main(String[] args……",
                    Id=111,
                    Status=ProblemStatus.Cancelled,
                },
                new ProblemModel
                {
                    PublishTime =DateTime.Now,
                    Author=new UserModel{Name="28zhu",Id=2},
                    Title=" 如何使用U盘防护系统的运行",
                    Abstract="java语言写的代码需要先编译为可执行文件，才能被jvm执行。在下载的jdk安装目录下的bin目录，有两个可执行程序java.exe和javac.exe，javac就是用来编译的，java是执行编译后的class文件。刚写好的java程序是.java结尾的文件，需要经过编译，变为.class结尾的文件，然后交给虚拟机执行。新建一个HelloWorld.java文件，将以下代码贴入：public class HelloWorld { public static void main(String[] args……",
                    Id=222,
                    Status=ProblemStatus.InProcess,
                },
                new ProblemModel
                {
                    PublishTime =DateTime.Now,
                    Author= new UserModel{ Name=" 友人 ",Id=3},
                    Title="为什么在给变量a赋值后，再使a=a++之后，输出a的值没有变化。",
                    Abstract="……",
                    Id=333,
                    Status=ProblemStatus.WaitedProcess,
                },
                new ProblemModel
                {
                    PublishTime =DateTime.Now,
                    Author=new UserModel{ Name=" WhiteWater " ,Id=4},
                    Title="手动导入jar包，运行报错的问题",
                    Abstract="运行就报这个错误，这个jar包我导入项目了的，不然编译都无法通过。…",
                    Id=444,
                    Status=ProblemStatus.Rewarded,
                },
                 new ProblemModel
                {
                    PublishTime =DateTime.Now,
                    Author=new UserModel{ Name=" WhiteWater " ,Id=4},
                    Title="手动导入jar包，运行报错的问题",
                    Abstract="运行就报这个错误，这个jar包我导入项目了的，不然编译都无法通过。…",
                    Id=444,
                    Status=ProblemStatus.Rewarded,
                },
                  new ProblemModel
                {
                    PublishTime =DateTime.Now,
                    Author=new UserModel{ Name=" WhiteWater " ,Id=4},
                    Title="手动导入jar包，运行报错的问题",
                    Abstract="运行就报这个错误，这个jar包我导入项目了的，不然编译都无法通过。…",
                    Id=444,
                    Status=ProblemStatus.Rewarded,
                },
                   new ProblemModel
                {
                    PublishTime =DateTime.Now,
                    Author=new UserModel{ Name=" WhiteWater " ,Id=4},
                    Title="手动导入jar包，运行报错的问题",
                    Abstract="运行就报这个错误，这个jar包我导入项目了的，不然编译都无法通过。…",
                    Id=444,
                    Status=ProblemStatus.Rewarded,
                }
            };
        }
        public List<ProblemModel> GetPaged(int PageIndex,int PageSize)
        {
            return _problemModel.Skip((PageIndex - 1) * PageSize).Take(PageSize).ToList();
        }
        public int GetSum()
        {
            return _problemModel.Count ;
        }
        public List<ProblemModel> GetExclude(ProblemStatus status)
        {
            return _problemModel.Where(p => p.Status != status).ToList();
        }
        public IList<ProblemModel> Get()
        {
            return _problemModel;
        }
        public void Add(ProblemModel model)
        {
            _problemModel .Add(model);
        }
        public void Delete(ProblemModel model)
        {
            _problemModel.Remove(model);
        }
    }
}
