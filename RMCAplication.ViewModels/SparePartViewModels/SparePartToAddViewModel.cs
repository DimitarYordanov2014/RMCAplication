using RMCAplication.Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static RMCAplication.Common.ModelConstants;

namespace RMCAplication.ViewModels.SparePartViewModels
{
    public class SparePartToAddViewModel
    {
        public SparePartToAddViewModel()
        {
            
        }
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(SparePartNameMaximumLenght)]
        public required string Name { get; set; }
        [MaxLength(DescriptionMaximumLenght)]
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
