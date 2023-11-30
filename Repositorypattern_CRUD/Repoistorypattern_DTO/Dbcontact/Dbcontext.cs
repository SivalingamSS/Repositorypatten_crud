using Microsoft.EntityFrameworkCore;
using Repoistorypattern_DTO.student_details_viewmodel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repoistorypattern_DTO.Dbcontact
{
    public class Dbcontext : DbContext
    {
        public Dbcontext(DbContextOptions options) : base (options) { }

        public DbSet<Employee> Studentsiva { get; set; }
    }
}
