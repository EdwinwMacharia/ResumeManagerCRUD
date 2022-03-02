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
        public virtual Application Application { get; private set; }
    }
    

}
