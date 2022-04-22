using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Nutz.Models
{
    // 000 - Create Project
    public class Category
    {
        [Key]
        public int Id { get; set; } // Id
        [Required]
        public string? Name { get; set; } // Name
        [DisplayName("Display Order")]
        [Range(1, 100, ErrorMessage = "Display Order must be between 1 and 100 only !")]
        public int DisplayOrder { get; set; } // DisplayOrder                                              
        public DateTime CreatedateTime { get; set; } = DateTime.Now; // CreatedateTime

    }
}
