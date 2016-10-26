using System;
using System.Collections.Generic;

namespace Master
{
    public class Node
    {
        public Guid Id { get; set; }
        public string Server { get; set; }
        public List<HttpRole> HttpRoles { get; set; }
    }
}