using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Resumemanager.Models
{
    public class Application
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; } = "";

        [Required]
        [StringLength(10)]
        public string Gender { get; set; } = "";
        
       

        [Required]
        [Range(25, 55, ErrorMessage ="Currently, We don't have a Vacancy for this Age")]
        [DisplayName("Age in years")]
        public int Age { get; set; }

        [StringLength (100)]
        public string Qualification { get; set; } = "";

        [Required]
        [Range(1,5, ErrorMessage ="Currently we don't have a position with that Experience")]
        [DisplayName("Total Experience Years")]
        public int TotalExperience { get; set; }

       
        public virtual List<Experience> Experiences { get; set;  } = new List<Experience>();

        public string PhotoUrl { get; set; }
        [Required(ErrorMessage = "Please choose a Profile photo")]
        [Display(Name ="Profile Photo" )]
        [NotMapped]
        public IFormFile ProfilePhoto { get; set; }

    }
}
