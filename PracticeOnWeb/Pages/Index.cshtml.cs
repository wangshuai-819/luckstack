using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace PracticeOnWeb.Pages
{
    public class IndexModel : PageModel
    {
        #region 原始自带
        //private readonly ILogger<IndexModel> _logger;

        //public IndexModel(ILogger<IndexModel> logger)
        //{
        //    _logger = logger;
        //}
        #endregion
        public IndexModel()
        {
            _problemRepository = new ProblemRepository();
        }
        private ProblemRepository _problemRepository;
        public IEnumerable<Problem> ProblemLists { get; set; }
        
        public void OnGet()  //html只会取onget 方法中的属性值   即要求model声明属性  
        {
            string exclude = Request.Query["exclude"];
            if (string.IsNullOrEmpty(exclude))
            {
                ProblemLists = _problemRepository.Get();
            }
            else
            {
                ProblemLists = _problemRepository.GetExclude(Enum.Parse<ProblemStatus>(exclude));
            }

        }
        public void OnPost()
        {

        }
    }
   
    public class ProblemRepository
    {
        private static IList<Problem> _problems;
        static ProblemRepository()
        {
            _problems = new List<Problem>
            {
                  new Problem
                {
                    PublishTime = DateTime.Now,
                    Author = new User { Name = " 那是花开911", Id = 111 },
                    Title = "ASP 网站迁移",
                    Id = 1,
                    Abstract = "在服务器上把原先的asp网站整体迁移出来，在新的服务器上重新布置……",
                    Status=ProblemStatus.Cancelled
                },
                     new Problem
                {
                    PublishTime = DateTime.Now,
                    Author = new User { Name = "  txdyr", Id = 222 },
                    Title = " Winform里控件绑定数据源就会报错",
                    Id = 2,
                    Abstract = " 项目里的控件绑定属性都会出现这个问题…… ",
                    Status=ProblemStatus.Rewarded,
                },
                       new Problem
                {
                    PublishTime = DateTime.Now,
                    Author = new User { Name = "   别闹", Id = 333 },
                    Title = " SQL Server多表查询,中间表有字段可能为空",
                    Id = 3,
                    Abstract = " 如图,表B中的D,E,F可能会是空,SQL怎么写,才能保证数据的一致性…… ",
                    Status=ProblemStatus.InProcess,
                },  new Problem
                {
                    PublishTime = DateTime.Now,
                    Author = new User { Name = "  ghwolf", Id = 444 },
                    Title = "  西安大专应届生找个JAVA开发的工作，有没有推荐的",
                    Id = 4,
                    Abstract = " 本人3个月后毕业，自学3年JAVA，对J2EE的一整套开发体系非常熟悉，OA类的项目做的比较多。荣获第八届蓝桥杯JAVA C组个人赛全国一等奖，之后去上海实习几个月，因为一些原因必须回西安发展，但是投简历无数，要么没有音信，要么第一轮面试结束没有消息，要么学历不过关--。智联上西安的JAVA校招几乎没有，1个月过去了，还是没有工作，我都不求工资，只求有长远发展，不会的我都愿意学，但是不想去那种混日子的公司，要有激情，有创新，有热血的公司。有没有推荐的，或者那位大神觉得我可以内推一下我，至少给个面试机会………… ",
                    Status=ProblemStatus.Rewarded,
                }
             };
        }
        public IList<Problem> Get()
        {
            return _problems;
        }
        public IList<Problem> GetExclude(ProblemStatus status)
        {
            return _problems.Where(p => p.Status != status).ToList();
        }
        public void Add(Problem problem)
        {
            _problems.Add(problem);
        }
        public void Delete(Problem problem)
        {
            _problems.Remove(problem);
        }
    }
    public enum ProblemStatus
    {
        [Description("已撤销")]
        Cancelled,
        [Description("协助中")]
        InProcess,
        [Description("已酬谢")]
        Rewarded,
    }
    public class Problem
    {
        public DateTime PublishTime { get; set; }
        public string Title { get; set; }
        public User Author { get; set; }
        public int Id { get; set; }
        public string Abstract { get; set; }
        public ProblemStatus Status { get; set; }
    }
    public class User
    {
        public string Name { get; set; }
        public int Id { get; set; }
    }

    public static class EnumDescription
    {
        public static string GetDescription<T>(this T value)
        {
            Type typeInfo = typeof(T);
            FieldInfo field = typeInfo.GetField (value.ToString());
            DescriptionAttribute attribute = (DescriptionAttribute)DescriptionAttribute.GetCustomAttribute(field, typeof(DescriptionAttribute));
            return attribute.Description;
        }
    }
   
}
