using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GameReviewSitePrototype.Models
{
    public class Developer
    {
        public virtual int DeveloperID { get; set; }
        public virtual string DeveloperName { get; set; }
        public virtual string DeveloperDescription { get; set; }
    }
}