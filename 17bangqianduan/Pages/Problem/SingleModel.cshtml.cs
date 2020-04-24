using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace _17bangqianduan.Pages.Problem
{
    public class SingleModelModel : PageModel
    {
        public ProblemModel problemModel { get; set; }
        private ProblemRepository _repository;
        public SingleModelModel()
        {
            _repository = new ProblemRepository();
        }
        public void OnGet()
        {
            int id = Convert.ToInt32(Request.RouteValues["id"]);
            //int id = Convert.ToInt32(RouteData.Values["id"]);
            problemModel = _repository.SingleGet(id);
        }
    }
}