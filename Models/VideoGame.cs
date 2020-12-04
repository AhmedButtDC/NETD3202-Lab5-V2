//Name:             Ahmed Butt
//Student ID:       100770449
//Project:          NETD3202 Lab 5
//Last Modified:    Dec 3, 2020

//This model is for VideoGames. Each page in VideoGames folder uses this to function correctly.

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
