using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMCAplication.Data.Models
{
    public class Warehouse
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public required string Name { get; set; }
        [MaxLength(150)]
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
