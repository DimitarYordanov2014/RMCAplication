using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMCAplication.Data.Models
{
    public class MechanizationSparePart
    {
        [Required]
        public int MechanizationId { get; set; }
        [ForeignKey(nameof(MechanizationId))]
        public Mechanization Mechanization { get; set; } = null!;
        [Required]
        public int SparePartId { get; set; }
        [ForeignKey(nameof(SparePartId))]
        public SparePart SparePart { get; set; } = null!;
    }
}
