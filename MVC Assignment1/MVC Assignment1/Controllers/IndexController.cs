using MVC_Assignment1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Assignment1.Controllers
{
    public class IndexController : Controller 
    {
        // GET: Index
        public ActionResult Index()
        {
            //declaration of variables
            List<SoccerTeam> lstTeams = new List<SoccerTeam>();
            List<SoccerTeam> lstSorted;
            int iTeamRank = 0;

            //Load the team info into the table
            lstTeams.Add(new SoccerTeam("RSL", 35));
            lstTeams.Add(new SoccerTeam("Colorado", 28));
            lstTeams.Add(new SoccerTeam("Florida", 12));
            lstTeams.Add(new SoccerTeam("Washington", 10));
            lstTeams.Add(new SoccerTeam("Wyoming", 34));
            lstTeams.Add(new SoccerTeam("Texas", 30));
            lstTeams.Add(new SoccerTeam("Rino", 4));

            //Sort the list from greatest to smallest
            lstSorted = lstTeams.OrderByDescending(x => x.points).ToList();

            ViewBag.Output = "<table>";
            ViewBag.Output += "<tr>";
            ViewBag.Output += "<th>Ranking</th>";
            ViewBag.Output += "<th>Team Name</th>";
            ViewBag.Output += "<th>Points</th>";
            ViewBag.Output += "</tr>";

            foreach (SoccerTeam oTeam in lstSorted)
            {
                iTeamRank++;
                ViewBag.Output += "<tr>";
                ViewBag.Output += "<td>" + iTeamRank + "</td>";
                ViewBag.Output += "<td>" + oTeam.name + "</td>";
                ViewBag.Output += "<td>" + oTeam.points + "</td>";
                ViewBag.Output += "</tr>";
            }
            ViewBag.Output += "</table>";
            return View();
        }
    }
}