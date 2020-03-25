using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace GameReviewSitePrototype.Models
{
    public class GameDataInitialiser: DropCreateDatabaseAlways<GameReviewSitePrototypeContext>
    {
        protected override void Seed(GameReviewSitePrototypeContext context)
        {
            //initialise games db connection for game 1
            Games game1 = new Games();

            //set game id data
            game1.GameID = 1;
            //set game name data
            game1.GameName = "Call Of Duty";
            //set game release date
            //game1.GameReleaseDate = Convert.ToDateTime("10/10/2010");
            //set game active
            game1.GameActive = true;
            //add
            context.Games.Add(game1);

            //initialise games db connection for game 2
            Games game2 = new Games();

            //set game id data
            game2.GameID = 2;
            //set game name data
            game2.GameName = "Halo";
            //set game release date
            //game1.GameReleaseDate = Convert.ToDateTime("11/12/2005");
            //set game active
            game2.GameActive = true;
            //add
            context.Games.Add(game2);

            //initialise review db connection for review 1 
            Review rev1 = new Review();

            //set review id
            rev1.ReviewID = 1;
            //set the review title
            rev1.ReviewTitle = "Cod is a good game";
            //set the review content
            rev1.ReviewContent = "Smooth fps shooter with a variety of gamemodes and weapons.";
            //set the review score
            rev1.ReviewScore = 3;
            //set the review Time stamp
            //rev1.ReviewTimeStamp = Convert.ToDateTime(DateTime.Now);
            //add
            context.Reviews.Add(rev1);


            //initialise review db connection for review 2 
            Review rev2 = new Review();

            //set review id
            rev2.ReviewID = 2;
            //set game id
            rev2.GameID = 2;
            //set the review title
            rev2.ReviewTitle = "Halo is a very good game";
            //set the review content
            rev2.ReviewContent = "Smooth fps shooter with a variety of gamemodes and weapons.";
            //set the review score
            rev2.ReviewScore = 4;
            //set the review Time stamp
            //rev1.ReviewTimeStamp = Convert.ToDateTime(DateTime.Now);
            //add
            context.Reviews.Add(rev2);

            base.Seed(context);
        }
    }
}