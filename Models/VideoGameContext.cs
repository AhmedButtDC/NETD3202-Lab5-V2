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
    }
}
