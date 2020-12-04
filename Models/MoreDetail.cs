//Name:             Ahmed Butt
//Student ID:       100770449
//Project:          NETD3202 Lab 5
//Last Modified:    Dec 3, 2020

//This model is used for MoreDetails folder. It assists with the entire function of the pages.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NETD3202_Lab5_V2.Models
{
    public class MoreDetail
    {
        [Key]
        public int gID { get; set; }
        public string description { get; set; }
        [ForeignKey("gID")]
        public VideoGame gameID { get; set; }
    }
}
