using System;
using System.Collections.Generic;
using System.Linq;
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
            ProblemLists = _problemRepository.Get();

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
             };
        }
        public IList<Problem> Get()
        {
            return _problems;
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
        Cancelled,
        InProcess,
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
}
