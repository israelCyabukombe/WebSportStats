using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MySportsStatAPP.Models
{
    public class Coach
    {
        [Required]
        public int CoachID { get; set; }
        [Required]
        [MaxLength(20)]
        public string FirstName { get; set; }
        [Required]
        [MaxLength(20)]
        public string LastName { get; set; }
        [Required]
        public int TeamID { get; set; }
        [Required]
        public Team MyTeam { get; set; }
    }
}
