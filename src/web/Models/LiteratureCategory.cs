using System.ComponentModel.DataAnnotations;

namespace Web.Models
{
    public class LiteratureCategory
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        [Required]
        public string Code { get; set; }
    }
}