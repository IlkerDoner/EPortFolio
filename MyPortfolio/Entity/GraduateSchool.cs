using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyPortfolio.Entity
{
    public class GraduateSchool
    {
        public int GraduateSchoolId { get; set; }
        public string GraduateSchoolName { get; set; }
        public string GraduateDepartment { get; set; }
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime GraduateDate { get; set; }
    }
}
