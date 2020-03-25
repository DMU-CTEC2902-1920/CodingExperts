using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GameReviewSitePrototype.Models
{
    public class GamesModel
    {
       
        public string GameID { get; set; }
        public string GameName { get; set; }
        public string GameDescription { get; set; }
        public decimal Price { get; set; }
    }
}