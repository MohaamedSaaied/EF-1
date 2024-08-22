using EF_1.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_1
{
    internal class iti_Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        =>
        optionsBuilder.UseSqlServer(" Server = . ; Database = iti ; Trusted-Connection = true ");
    
        public iti_Context():base(){}
        
        
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            // By Fluent Api
            modelBuilder.Entity<Instructor>().HasKey(E=>E.id);
            modelBuilder.Entity<Instructor>().Property(E=>E.id).UseIdentityColumn(1,1);
            modelBuilder.Entity<Instructor>().Property(E => E.Adress).HasColumnType("varchar").HasMaxLength(50);

            // Class Configration
            modelBuilder.ApplyConfiguration(new StudentCourseConfig());


            base.OnModelCreating(modelBuilder);
        }
        
        
        // By DbContext 
        public DbSet<Course> Course { get; set; }
    }
}
