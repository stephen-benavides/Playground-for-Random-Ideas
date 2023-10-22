using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace EntityPracticeForms
{
    public class Course
    {
        public string Author { get; set; }
        public int Cost { get; set; }
    }
    public class ProgramDbContext : DbContext
    {
        public DbSet<Course> Courses { get; set; }
    }
}
