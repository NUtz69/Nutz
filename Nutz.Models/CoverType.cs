using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
 
namespace Nutz.Models
{
    // 001 - Repository Pattern
    public class CoverType
    {
        [Key]
        public int Id { get; set; } // Id

        [Required]
        [DisplayName("Cover Type")]
        [MaxLength(50)]
        public string? Name { get; set; } // Name
    }
}
