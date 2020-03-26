//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web;
//using System.Data.Entity;
//using GameReviewSitePrototype.Data;

//namespace GameReviewSitePrototype.Models
//{
//    public class DeveloperDataInitialiser: DropCreateDatabaseAlways<DeveloperContext>
//    {
//        protected override void Seed(DeveloperContext context)
//        {
//            Developer dev1 = new Developer();
//            dev1.DeveloperID = 1;
//            dev1.DeveloperName = "Activision";
//            dev1.DeveloperDescription = "This is a major developer";
//            context.Developers.Add(dev1);

//            Developer dev2 = new Developer();
//            dev2.DeveloperID = 2;
//            dev2.DeveloperName = "EA";
//            dev2.DeveloperDescription = "This is a big developer";
//            context.Developers.Add(dev2);

//            Games game1 = new Games();
//            game1.GameID = 1;
//            game1.GameName = "CoD";
//            game1.GameActive = true;
//            game1.GameDescription = "First person shooter";
//            context.Games.Add(game1);

//            Games game2 = new Games();
//            game2.GameID = 2;
//            game2.GameName = "Fifa 20";
//            game2.GameActive = true;
//            game2.GameDescription = "Football";
//            context.Games.Add(game2);

//            base.Seed(context);
//        }
//    }
//}
// THIS CLASS IS NOT NEEDED. AUTOMATIC CONNECTION TO THE DATABASE WITHOUT THE INITIALISER.