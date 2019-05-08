using System.Collections.Generic;

namespace Web.Models
{
    public class Literature
    {
        public LiteratureType Type { get; set; }
        public IEnumerable<LiteratureCategory> Categories { get; set; }
        public string Title { get; set; }
    }

    public class LiteratureCategory
    {
        public string Name { get; set; }
        public string Code { get; set; } 
    }

    public enum LiteratureType
    {
        Book,
        Magazine,
        Article
    }
}