using Microsoft.EntityFrameworkCore;
using MyPortfolio.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyPortfolio.Repository.Concrete.EntityFramework
{
    public class MySiteDbContext : DbContext
    {
        public MySiteDbContext(DbContextOptions<MySiteDbContext> mysitedbcontex) : base(mysitedbcontex)
        {

        }
        public DbSet<Employment> Employments { get; set; }
        public DbSet<GeneralSkills> GeneralSkills { get; set; }
        public DbSet<GraduateSchool> GraduateSchools { get; set; }
        public DbSet<MyProjects> MyProjects { get; set; }
        public DbSet<PersonMainDescription> PersonMainDescriptions { get; set; }

    }
}
