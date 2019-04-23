using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace KancelarijaApi.Expressions
{
    public class FilterInfo
    {
        public string Condition { get; set; }
        public List<RuleInfo> Rules { get; set; } = new List<RuleInfo>();
    }
}
