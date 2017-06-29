using MySportsStatAPP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MySportsStatAPP.ViewModels
{
    public class CoachTeamPlayerViewModel
    {
        public Team myTeam { get; set; }
        public Coach myCoach { get; set; }

        public Player myPlayer { get; set; }
    }
}
