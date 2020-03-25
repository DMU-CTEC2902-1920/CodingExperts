using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GameReviewSitePrototype.Models
{
    public class Review
    {
        public virtual int ReviewID { get; set; }
        public virtual string ReviewTitle { get; set; }
        public virtual string ReviewContent { get; set; }
        public virtual int ReviewScore { get; set; }
        //public virtual DateTime ReviewTimeStamp { get; set; }
        public virtual int UserID { get; set; }
        public virtual int GameID { get; set; } 
    }
}