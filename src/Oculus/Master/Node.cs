using System.Collections.Generic;

namespace Master
{
    public class Node
    {
        public string ServerName { get; set; }
        public List<HttpRole> HttpRoles { get; set; }
    }
}