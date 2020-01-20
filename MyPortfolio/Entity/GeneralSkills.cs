using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyPortfolio.Entity
{
    public class GeneralSkills
    {
        public int GeneralSkillsId { get; set; }
        [Required]
        public string GeneralSkillsName { get; set; }
        [Required]
        [Range(0,100)]

        public int GeneralSkillsPercentage { get; set; }
    }
}
