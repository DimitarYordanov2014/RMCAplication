using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMCAplication.Data.Models
{
    public class Person
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public required string Name { get; set; }
        [Required]
        public bool IsDeleted { get; set; } = false;
        [Required]
        public ICollection<Tool> Tools { get; set; } = new HashSet<Tool>();
    }
}
