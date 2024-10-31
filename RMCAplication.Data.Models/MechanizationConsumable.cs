using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMCAplication.Data.Models
{
    public class MechanizationConsumable
    {
        [Required]
        public int MechanizationId { get; set; }
        [ForeignKey(nameof(MechanizationId))]
        public Mechanization Mechanization { get; set; } = null!;
        [Required]
        public int ConsumableId { get; set; }
        [ForeignKey(nameof(ConsumableId))]
        public Consumable Consumable { get; set; } = null!;
    }
}
