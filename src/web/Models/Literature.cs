using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Web.Models
{
    public class Literature
    {
        public int Id { get; set; }
        
        [Required]
        [MaxLength(100)]
        public string Title { get; set; }

        [MaxLength(1000)]
        public string Description { get; set; }

        [Required]
        [MaxLength(50)]
        public string Author { get; set; }

        public string Translator { get; set; }

        [Required]
        public LiteratureType Type { get; set; }

        [Required]
        public IEnumerable<LiteratureCategory> Categories { get; set; }

        public Publication Publication { get; set; }
    }
}