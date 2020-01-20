using MyPortfolio.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyPortfolio.Models
{
    public class MyProjectModel
    {
        public int MyProjectsId { get; set; }
        public string MyProjectHeader { get; set; }
        public string MyProjectDescription { get; set; }
        public string MyProjectSmallDescription { get; set; }
        public string MyProjectImages { get; set; }
        public string MyProjectLink { get; set; }
    }
}
