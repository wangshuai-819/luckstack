using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace _17bangqianduan.Pages.Problem
{
    public class IndexModel : PageModel
    {
        public IndexModel()
        {
            _repository = new ProblemRepository();
        }
        private ProblemRepository _repository;
        public IList<ProblemModel> ProblemModels { get; set; }
        public int SumProblems { get; set; }
        public void OnGet()
        {
            string exclude = Request.Query["exclude"];
            if (string.IsNullOrEmpty(exclude))
            {
                ProblemModels = _repository.Get();
            }
            else
            {
                ProblemModels = _repository.GetExclude(Enum.Parse<ProblemStatus>(exclude));

            }
            int PageIndex = Convert.ToInt32(Request.Query[Const.pageIndex]);
            ProblemModels = _repository.GetPaged(PageIndex, Const.pageSize);
            SumProblems = _repository.GetSum();
        }
        public void OnPost()
        {

        }
    }
}