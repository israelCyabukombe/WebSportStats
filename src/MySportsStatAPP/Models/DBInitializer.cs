using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MySportsStatAPP.Models;


namespace MySportsStatAPP.Models
{
    public class DBInitializer
    {
        public static void Initialize(SportsDbContext context)
        {
            context.Database.EnsureCreated();
            if (context.Teams.Any())
            {
                return;
            }
            var teams = new Team[]
            {
                new Team { TeamName = "Golden State Wariors", CoachID = 1111},
                new Team { TeamName = "Cleveland Cavaliers", CoachID=2222 }
            };
            foreach (Team t in teams)
            {
                context.Teams.Add(t);
            }
            context.SaveChanges();

            var players = new Player[]
            {
                new Player { FirstName ="Steph",LastName="Curry"},
                new Player { FirstName ="Klay",LastName="Thompson"},
                new Player { FirstName ="Kevin",LastName="Durant" },
                new Player { FirstName ="Draymond",LastName="Green"},
                new Player { FirstName ="Zaza",LastName="Pachulia"},

                new Player { FirstName ="Kyrie",LastName="Irving"},
                new Player { FirstName ="Lebron",LastName="James"},
                new Player { FirstName ="JR",LastName="Smith"},
                new Player { FirstName ="Kevin",LastName="Love"},
                new Player { FirstName ="Tristan",LastName="Thompson"}
            };
            foreach(Player p in players)
            {
                context.Players.Add(p);
            }
            context.SaveChanges();

            var coaches = new Coach[]
            {
                new Coach { FirstName="Steve", LastName="Kerr"},
                new Coach { FirstName="Tyrone", LastName="Lue"}
            };
            foreach(Coach c in coaches)
            {
                context.Add(c);
            }
            context.SaveChanges();

        }
    }
        
}
