using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMCAplication.Data.Models
{
    public class Mechanization
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(150)]
        public required string Name { get; set; }
        [Required]
        public bool IsDeleted { get; set; } = false;
        public ICollection<MechanizationSparePart> MechanizationSpareParts { get; set; } = new List<MechanizationSparePart>();
        public ICollection<MechanizationConsumable> MechanizationConsumables { get; set; } = new List<MechanizationConsumable>();
    }
}
