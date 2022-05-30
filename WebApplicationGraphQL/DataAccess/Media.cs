using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationGraphQL.DataAccess
{
    public class Media
    {
        public ICollection<Node> Nodes { get; set; }
    }

    public class Node
    {
        public ICollection<Title> Titles { get; set; }
    }
    public class Title
    {
        public string English { get; set; }
        public string Native { get; set; }
    }
}
