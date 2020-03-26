using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity.Infrastructure;

namespace GameReviewSitePrototype.Models
{
    public class Developer
    {
        //defines the key in the class: "DeveloperID" = KEY
        [Key]
        public virtual int DeveloperID { get; set; }
        //additional field allowing to differ between Developers
        public virtual string DeveloperName { get; set; }
        //field adding the description
        public virtual string DeveloperDescription { get; set; }

    }
}