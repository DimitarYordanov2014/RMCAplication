using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static RMCAplication.Common.ModelConstants;

namespace RMCAplication.Data.Models
{
    public class Consumable
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(ConsumableNameMaximumLenght)]
        public required string Name { get; set; }
        [MaxLength(DescriptionMaximumLenght)]
        public string? Description { get; set; }
        [Required]
        public int WarehouseId { get; set; }
        [Required]
        [ForeignKey(nameof(WarehouseId))]
        public Warehouse Warehouse { get; set; } = null!;
        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }
        [Required]
        public int Count { get; set; }
        public ICollection<MechanizationConsumable> MechanizationConsumables { get; set; } = new List<MechanizationConsumable>();
        [Required]
        public bool IsDeleted { get; set; }
    }
}
