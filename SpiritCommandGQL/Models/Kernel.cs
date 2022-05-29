using System.ComponentModel.DataAnnotations;

namespace SpiritCommandGQL.Models
{
    public class Kernel
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        public string LicenceKey { get; set; }
    }
}
