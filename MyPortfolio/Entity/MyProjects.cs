using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyPortfolio.Entity
{
    public class MyProjects
    {
        public int MyProjectsId { get; set; }
        public string MyProjectHeader { get; set; }
        public string MyProjectLongDescription { get; set; }
        public string MyProjectSmallDescription { get; set; }
        public UsedStack usingStacks { get; set; }
        public string MyProjectImages { get; set; }
        public string MyProjectLink { get; set; }
    }
    public enum UsedStack
    {
        NETCORE,
        NETCOREMVC,
        HTML,
        CSS,
        JAVASCRIPT
    }
}
