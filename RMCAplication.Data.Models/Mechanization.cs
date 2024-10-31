using System.ComponentModel.DataAnnotations;
using static RMCAplication.Common.ModelConstants;

namespace RMCAplication.Data.Models
{
    public class Mechanization
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(MechanizationNameMaximumLenght)]
        public required string Name { get; set; }
        [Required]
        public bool IsDeleted { get; set; } = false;
        public ICollection<MechanizationSparePart> MechanizationSpareParts { get; set; } = new List<MechanizationSparePart>();
        public ICollection<MechanizationConsumable> MechanizationConsumables { get; set; } = new List<MechanizationConsumable>();
    }
}
