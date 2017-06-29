using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MySportsStatAPP.Models;
using MySportsStatAPP.ViewModels;
// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace MySportsStatAPP.Controllers
{
    public class HomeController : Controller
    {
        /* Scaffolding effect*/
        //****************************************
        //function: 
        //Description:
        //****************************************
        private readonly SportsDbContext _context;
        public HomeController( SportsDbContext context)
        {
            _context = context;
        }
        //****************************************
        //function: 
        //Description:
        //****************************************
        // GET: /<controller>/
        public IActionResult Index()
        {
            @ViewBag.value = "Sports Statistics!!!";
            return View();
        }
        //****************************************
        //function: 
        //Description:
        //****************************************
        public IActionResult Basketball()
        {
            /* CoachTeamPlayerViewModel CTPViewModel = new CoachTeamPlayerViewModel();
             CTPViewModel.myTeam = GetTeamModel();
             CTPViewModel.myCoach = GetCoachModel();
             CTPViewModel.myPlayer = GetPlayerModel();*/

            var CTPViewModel = new Tuple<Coach, Player, Team>(GetCoachModel(), GetPlayerModel(), GetTeamModel());
            return View();
        }

        //****************************************
        //function: 
        //Description:
        //****************************************
        public IActionResult Soccer()
        {
            return View();
        }
        public IActionResult RecentStats()
        {
            return View();
        }
        //****************************************
        //function: 
        //Description:
        //****************************************
        public IActionResult about()
        {
            return View();
        }
        //****************************************
        //function: 
        //Description:
        //****************************************
        public IActionResult Contact()
        {
            return View();
        }

        //****************************************
        //function:  GetTeamModel
        //****************************************
        public Team GetTeamModel()
        {
            Team tModel = new Team();

            return tModel;
        }

        //****************************************
        //function:  GetCoachModel
        //****************************************
        public Coach GetCoachModel()
        {
            Coach cModel = new Coach();

            return cModel;    
        }

        //****************************************
        //function:  GetPlayerModel
        //****************************************
        public Player GetPlayerModel()
        {
            Player pModel = new Player();
            return pModel;
        }


    }
}
