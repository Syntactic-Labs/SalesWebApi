using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebApi.Models
{
    public class AppDbContext : DbContext
    {
        //Dbset collections go here
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<Orderline> Orderlines { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder) { }
        
        
        
        
        //This is all in the {} above. it is an example of fluent api using EdDb as an example
        /*builder.Entity<Major>(e => {
         * e.ToTable("Majors");    --table name
         * e.HasKey(p => p.Id);    --primary key
         * e.Property(p => p.Code).HasMaxLength(15).IsRequired(true);
         * e.HasIndex(p => p.Code).IsUnique(true);
         * e.Property(p => p.Description).HasMaxLength(30).IsRequired(true);
         * e.Property(p = p.MinSat);
         *});
         *
         *builder.Entity<Student>(e => {
         *  e.ToTable("Students");
         *  e.HasKey(p => p.Id);
         *  e.Property(p => p.Firstname).HasMaxLength(30).IsRequired(true);
         *  e.Property(p => p.Lastname).HasMaxLength(30).IsRequired(true);
         *  e.Property(p => p.SAT);
         *  e.Property(p => p.GPA).HasColumnType("deciaml(5,1)");
         *  e.HasOne(p => p.Major)
         *       .WithMany(p => p.Students)
         *       .HasForeignKey(p => p.MajorId)
         *       .OnDelete(DeleteBahavior.Restrict);
         *}); */
    }
}
