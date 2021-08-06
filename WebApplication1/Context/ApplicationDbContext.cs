using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        { 
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder); 
            builder.Entity<ACTORS>().ToTable("ACTORS"); 
            builder.Entity<CATEGORIES>().ToTable("CATEGORIES"); 
            builder.Entity<MOVIES>().ToTable("MOVIES"); 
            builder.Entity<DET_CATEG_MOVIE>().ToTable("DET_CATEG_MOVIE"); 
            builder.Entity<DET_ACTOR_MOVIE>().ToTable("DET_ACTOR_MOVIE");
            builder.Entity<USP_MOVIES_Q01>().ToTable("USP_MOVIES_Q01");
            
        } 
        public DbSet<ACTORS> ACTORS{ get; set; }
        public DbSet<CATEGORIES> CATEGORIES { get; set; }
        public DbSet<MOVIES> MOVIES { get; set; }
        public DbSet<DET_CATEG_MOVIE> DET_CATEG_MOVIE { get; set; }
        public DbSet<DET_ACTOR_MOVIE> DET_ACTOR_MOVIE { get; set; }
        public DbSet<USP_MOVIES_Q01> USP_MOVIES_Q01 { get; set; }
        
    }
}
