using System.ComponentModel.DataAnnotations;
using static RMCAplication.Common.ModelConstants;

namespace RMCAplication.Data.Models
{
    public class Person
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(PersonNameMaximumLenght)]
        public required string Name { get; set; }
        [Required]
        public bool IsDeleted { get; set; } = false;
        [Required]
        public ICollection<Tool> Tools { get; set; } = new HashSet<Tool>();
    }
}
