using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyPortfolio.Models
{
    public class MainPersonelContextModel
    {
        [Required]
        public string PersonName { get; set; }
        [Required]
        public string PersonWorkInstructure { get; set; }
        [Required]
        public int Age { get; set; }
        [Required]

        public string PhoneNumber { get; set; }
        [Required]

        public string Email { get; set; }


        public string PersonImage { get; set; }
        [Required]

        public string Adress { get; set; }
        [Required]

        public string HelloHeaderDescription { get; set; }
        [Required]
        public string HelloSectionDescription { get; set; }
        [Required]

        public string ResumeHeaderDescription { get; set; }
        [Required]
        public string ResumeSectionDescription { get; set; }
        [Required]
        public string GithubLink { get; set; }
        [Required]
        public string LinkedikLink { get; set; }
        [Required]
        public string Skype { get; set; }
     
    }
}
