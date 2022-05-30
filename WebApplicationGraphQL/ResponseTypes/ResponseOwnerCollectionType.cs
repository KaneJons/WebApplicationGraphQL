using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationGraphQL.DataAccess;

namespace WebApplicationGraphQL.ResponseTypes
{
    public class ResponseOwnerCollectionType
    {
        public List<Page> Pages { get; set; }
    }
}
