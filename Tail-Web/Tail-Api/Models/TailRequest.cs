using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Tail.Api.Models
{
    public class TailRequest
    {
        public string FileName { get; set; }

        public long from { get; set; }
    }
}