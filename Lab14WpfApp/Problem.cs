using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab14WpfApp
{
    public enum ProblemTypes
    {
        Home,
        Work
    }
    public class Problem
    {
        public string ProblemName { get; set; }
        public string Description { get; set; }
        public int Priority { get; set; }
        public ProblemTypes ProblemType { get; set; }
    }
}
