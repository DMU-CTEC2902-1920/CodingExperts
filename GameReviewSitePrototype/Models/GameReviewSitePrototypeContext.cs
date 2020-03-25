using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using GameReviewSitePrototype.Models;

namespace GameReviewSitePrototype.Models
{
    public class GameReviewSitePrototypeContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public GameReviewSitePrototypeContext() : base("name=GameReviewSitePrototypeContext")
        {
        }
        //for review
        public System.Data.Entity.DbSet<Review> Reviews { get; set; }
        //for games
        public System.Data.Entity.DbSet<Games> Games { get; set; }
    }
}
