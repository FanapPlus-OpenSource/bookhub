using System.ComponentModel.DataAnnotations;

namespace Web.Models
{
    public class LiteratureCategory
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Code { get; set; }
    }
}