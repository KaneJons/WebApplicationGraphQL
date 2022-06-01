using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationGraphQL.DataAccess
{
    public class Media
    {
        public  IList<Node> Nodes { get; set; }
    }

    public class Node
    {
        public Title Title { get; set; }
    }
    public class Title
    {
        public string English { get; set; }
    }

    
}
