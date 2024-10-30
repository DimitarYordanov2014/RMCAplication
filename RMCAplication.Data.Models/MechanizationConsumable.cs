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
        public int ConsuableId { get; set; }
        [ForeignKey(nameof(ConsuableId))]
        public Warehouse Consumable { get; set; } = null!;
    }
}
