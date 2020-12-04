//Name:             Ahmed Butt
//Student ID:       100770449
//Project:          NETD3202 Lab 5
//Last Modified:    Dec 3, 2020

//This is the context class for both VideoGame and MoreDetail classes.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace NETD3202_Lab5_V2.Models
{
    public class VideoGameContext : DbContext
    {
        //Constructor
        public VideoGameContext(DbContextOptions<VideoGameContext> options) : base(options)
        {
            
        }

        public DbSet<VideoGame> VideoGames { get; set; }
        public DbSet<MoreDetail> MoreDetails { get; set; }

        //Note: I wasn't sure whether to make a separate context file for MoreDetail or not.
    }
}
