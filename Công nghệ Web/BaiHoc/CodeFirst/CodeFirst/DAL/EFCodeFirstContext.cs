using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CodeFirst.Models;
using System.Data.Entity;

namespace CodeFirst.DAL
{
    public class EFCodeFirstContext
    {
        public class MyCodeFirstContext : DbContext
        {
            public MyCodeFirstContext() : base("EFCodeFirstContext"){

            }

            public DbSet<Student> Students { get; set; }
            public DbSet<Enrollment> Enrollments { get; set; }
            public DbSet<Course> Courses { get; set; }
        }
    }
}