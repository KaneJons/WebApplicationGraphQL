using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationGraphQL.DataAccess
{
    public class Character
    {
        public ICollection<Name> Names { get; set; }
        public ICollection<Media> Medias { get; set; }
        public string Gender { get; set; }
        public string Description { get; set; }
    }

    public class Page
    {
        public ICollection<Character> Characters { get; set; }
    }
}
