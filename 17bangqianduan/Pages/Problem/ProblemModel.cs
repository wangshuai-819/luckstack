using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace _17bangqianduan.Pages.Problem
{
    public class ProblemModel
    {
        public DateTime PublishTime { get; set; }
        public UserModel Author { get; set; }
        public ProblemStatus Status { get; set; }
        public string Title { get; set; }
        public string Abstract { get; set; }
        public int Id { get; set; }
        public string[] keywords { get; set; }
    }
    public enum ProblemStatus
    {
        [Description("已撤销")]
        Cancelled,
        [Description("待协助")]
        WaitedProcess,
        [Description("已协助")]
        InProcess,
        [Description("已酬谢")]
        Rewarded,
    }
}
