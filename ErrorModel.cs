using System;
using System.Collections.Generic;
using System.Text;

namespace NetCore.Simple.Core
{
    public class ErrorModel
    {
        public string Key { get; set; }
        public IEnumerable<string> Errors { get; set; }
    }
}
