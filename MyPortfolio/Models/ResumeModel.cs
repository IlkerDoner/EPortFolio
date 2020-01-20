using MyPortfolio.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyPortfolio.Models
{
    public class ResumeModel
    {
        public string ResumeHeaderDescription { get; set; }
        public string ResumeSectionDescription { get; set; }

        // graduate
        public string GraduateSchoolName { get; set; }
        public string GraduateDepartment { get; set; }
        public DateTime GraduateDate { get; set; }
        //employement
        public string EmploymentNames { get; set; }
        public string EmploymentDescription { get; set; }
        public DateTime EmploymentDate { get; set; }
    }
}
