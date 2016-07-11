using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebStringStack.Models
{
    [Serializable]
    public class ApiResultModel
    {
        public string data { get; set; }
        public bool success { get; set; }
    }
}
