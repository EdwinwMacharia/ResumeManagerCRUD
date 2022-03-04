using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Resumemanager.Models
{
    public class Experience
    {
        public Experience()
            {

            }
        [Key]
        public int ExperienceId { get; set; }
        [ForeignKey("Application")]
        public int ApplicantId { get; set; }

        [Required]
        [StringLength(100)]
        public string CompanyName { get; set; } = "";

        [Required]
        [StringLength(50)]
        public string Designation { get; set; } = "";

        [Required]
        [StringLength(10)]
        public int YearsWorked { get; set; }

        public virtual Application Application { get; private set; }
    }
    

}
