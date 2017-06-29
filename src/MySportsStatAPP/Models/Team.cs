using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MySportsStatAPP.Models
{
    public class Team
    {
        [Required]
        public int TeamID { get; set; }
        [Required]
        [MaxLength(20)]
        public string TeamName { get; set; }
        [Required]
        public int CoachID { get; set; }
        public List<Player> players{ get; set; }
    }
}
