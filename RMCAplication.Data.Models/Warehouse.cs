using System.ComponentModel.DataAnnotations;
using static RMCAplication.Common.ModelConstants;

namespace RMCAplication.Data.Models
{
    public class Warehouse
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(WarehouseNameMaximumLenght)]
        public string Name { get; set; } = null!;
        [MaxLength(DescriptionMaximumLenght)]
        public string? Description { get; set; }
        [Required]
        public bool IsDeleted { get; set; } = false;
        [Required]
        public ICollection<Tool> Tools { get; set; } = new List<Tool>();
        [Required]
        public ICollection<Consumable> Consumables { get; set; } = new List<Consumable>();
        [Required]
        public ICollection<SparePart> SpareParts { get; set; } = new List<SparePart>();
    }
}
