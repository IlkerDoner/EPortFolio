using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyPortfolio.Entity
{
    public class PersonMainDescription
    {
        public int PersonMainDescriptionId { get; set; }
        public string PersonName { get; set; }
        public string PersonWorkInstructure { get; set; }
        public int Age { get; set; }

        public string PhoneNumber { get; set; }
        
        public string Email { get; set; }

        public string PersonImage { get; set; }
        [RegularExpression(@"^.{5,}$", ErrorMessage = "Minimum 3 characters required")]
        [StringLength(30, MinimumLength = 3)]
        public string Adress { get; set; }

        [RegularExpression(@"^.{5,}$", ErrorMessage = "Minimum 3 characters required")]
        [StringLength(10, MinimumLength = 3)]
        public string HelloHeaderDescription  { get; set; }
        [RegularExpression(@"^.{5,}$", ErrorMessage = "Minimum 50 characters required")]
        [StringLength(50, MinimumLength = 380)]
        public string HelloSectionDescription { get; set; }
        [RegularExpression(@"^.{5,}$", ErrorMessage = "Minimum 3 characters required")]
        [StringLength(10, MinimumLength = 3)]
        public string ResumeHeaderDescription { get; set; }
        [RegularExpression(@"^.{5,}$", ErrorMessage = "Minimum 50 characters required")]
        [StringLength(50, MinimumLength = 380)]
        public string ResumeSectionDescription { get; set; }

        public string Skype  { get; set; }
        public string GithubLink { get; set; }
        public string LinkedikLink { get; set; }
        

    }
}
