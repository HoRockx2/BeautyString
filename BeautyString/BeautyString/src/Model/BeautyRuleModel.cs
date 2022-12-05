using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautyString.Model
{
    public class BeautyRuleModel
    {
        public string RuleName { get; set; }
        public List<KeyValuePair<string, string>> Rules { get; set; } = new List<KeyValuePair<string, string>>();
    }
}
