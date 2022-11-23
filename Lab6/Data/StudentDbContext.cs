﻿using System;
using System.Runtime.ConstrainedExecution;
using Lab6.Models;
using Microsoft.EntityFrameworkCore;
namespace Lab6.Data
{
    public class StudentDbContext : DbContext
    {
        public StudentDbContext(DbContextOptions<StudentDbContext> options) : base(options)
        {
        }
        public DbSet<Lab6.Models.Student> Students { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>().ToTable("Students");
        }
    }
}