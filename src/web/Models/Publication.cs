using System.ComponentModel.DataAnnotations;

namespace Web.Models
{
    public class Publication
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        [Required]
        [MaxLength(10)]
        public string Code { get; set; }
    }
}