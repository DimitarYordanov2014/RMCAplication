using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMCAplication.Data.Models
{
    public class Consumable
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public required string Name { get; set; }
        [MaxLength(150)]
        public string? Description { get; set; }
        [Required]
        public required Warehouse Warehouse { get; set; }
        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }
        [Required]
        public bool inStock { get; set; } = false;
        [Required]
        public int Count { get; set; }
        public ICollection<MechanizationConsumable> MechanizationConsumables { get; set; } = new List<MechanizationConsumable>();
        [Required]
        public bool IsDeleted { get; set; }
    }
}
