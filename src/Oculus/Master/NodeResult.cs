using System;
using System.Collections.Generic;

namespace Master
{
    public class NodeResult
    {
        public Guid NodeId { get; set; }
        public List<HttpUrlResult> HttpUrlResults { get; set; }
    }
}