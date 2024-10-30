using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMCAplication.Data.Models
{
    public class SparePart
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public required string Name { get; set; }
        [MaxLength(150)]
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
        public ICollection<MechanizationSparePart> MechanizationSpareParts { get; set; } = new List<MechanizationSparePart>();
        [Required]
        public bool IsDeleted { get; set; }
    }
}
