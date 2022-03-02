using System.ComponentModel.DataAnnotations;

namespace Resumemanager.Models
{
    public class Application
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [Required]
        [StringLength(100)]
        public string Gender { get; set; }
    }
}
