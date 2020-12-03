using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace NETD3202_Lab5_V2.Models
{
    public class VideoGame
    {
        [Key]
        public int gameID { get; set; }
        public string gameName { get; set; }
        public int releaseYear { get; set; }
        public string esrb { get; set; }
        public int rating { get; set; }
    }
}
