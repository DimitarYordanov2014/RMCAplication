using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMCAplication.Data.Models
{
    public class MechanizationConsumable
    {
        public required int MechanizationId { get; set; }
        [ForeignKey(nameof(MechanizationId))]
        public required Mechanization Mechanization { get; set; }
        public required int ConsuableId { get; set; }
        [ForeignKey(nameof(ConsuableId))]
        public required Warehouse Consumable { get; set; }
    }
}
