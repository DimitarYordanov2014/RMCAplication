using RMCAplication.Data.Models;
using RMCAplication.Services.Mapping;
using System.ComponentModel.DataAnnotations;

namespace RMCAplication.ViewModels;

public class WarehouseViewModel : IMapFrom<Warehouse>, IMapTo<Warehouse>
{
    public WarehouseViewModel()
    {
        
    }
    [Key]
    public int Id { get; set; }
    [Required]
    [MaxLength(50)]
    public string Name { get; set; } = null!;
    [MaxLength(150)]
    public string? Description { get; set; }
    [Required]
    public ICollection<Tool> Tools { get; set; } = new List<Tool>();
    [Required]
    public ICollection<Consumable> Consumables { get; set; } = new List<Consumable>();
    [Required]
    public ICollection<SparePart> SpareParts { get; set; } = new List<SparePart>();
}
