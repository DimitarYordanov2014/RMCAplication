using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMCAplication.Data.Models
{
    public class MechanizationSparePart
    {
        public required int MechanizationId { get; set; }
        [ForeignKey(nameof(MechanizationId))]
        public required Mechanization Mechanization { get; set; }
        public required int SparePartId { get; set; }
        [ForeignKey(nameof(SparePartId))]
        public required SparePart SparePart { get; set; }
    }
}
