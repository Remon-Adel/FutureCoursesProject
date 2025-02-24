using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using FutureAcademy1.Models;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace FutureAcademy1.DAL
{
    public class UniversityContext:DbContext 
    {
        //make constructor to make the web.configuration file for specifying the database to use..

        public UniversityContext():base("UniversityContext")
        {

        }



        public DbSet<Student> Students { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Instructor> Instructors { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }


    }
}