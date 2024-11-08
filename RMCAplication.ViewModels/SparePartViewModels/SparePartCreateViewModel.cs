using RMCAplication.Data.Models;
using RMCAplication.Services.Mapping;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static RMCAplication.Common.ModelConstants;

namespace RMCAplication.ViewModels.SparePartViewModels
{
    public class SparePartCreateViewModel : IMapFrom<SparePart>
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(SparePartNameMaximumLenght
            , MinimumLength = SparePartMinimumLenght)]
        public string Name { get; set; } = string.Empty;
        [Required]
        [StringLength(DescriptionMaximumLenght
            , MinimumLength = DescriptionMinimumLenght)]
        public string? Description { get; set; }
        [Required]
        public int Count { get; set; }
        [Required]
        public int WarehouseId { get; set; }
        [Required]
        [ForeignKey(nameof(WarehouseId))]
        public Warehouse Warehouse { get; set; } = null!;

        public IList<MechanizationSparePart> MehanizationsSpareParts { get; set; } = new List<MechanizationSparePart>();
        public IList<Warehouse> warehouses { get; set; } = new List<Warehouse>();
        public IList<Mechanization> mechanizations { get; set; } = new List<Mechanization>();

        public IList<MechnisationCheckBoxItem> MechanisationChecked { get; set; } = new List<MechnisationCheckBoxItem>();
    }
}
