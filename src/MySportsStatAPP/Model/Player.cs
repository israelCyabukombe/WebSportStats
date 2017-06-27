using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MySportsStatAPP.Model
{
    public class Player
    {
       
        [Required]
         public int PlayerID { get; set; }
        [Required]
        [MaxLength(20)]
        public string FirstName { get; set; }
        [Required]
        [MaxLength(20)]
        public string LastName { get; set; }
        [Required]
        public int TeamID { get; set; }

        [NotMapped]
        public Team MyTeam { get; set; }





    }
}
