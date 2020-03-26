using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity.Infrastructure;

namespace GameReviewSitePrototype.Models
{
    public class Games
    {
        //primary key gameid var
        [Key]
        public virtual int GameID { get; set; }
        public virtual int DeveloperID { get; set; }
        //var for GameName
        public virtual string GameName { get; set; }
        //var for ReleaseDate
        //public virtual DateTime GameReleaseDate { get; set;}
        //var for Game Active
        public virtual Boolean GameActive { get; set; }
    }
}