using MyProject.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.DataAccess.Concrete.Context
{
    public class MyProjectContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-NG81CV5;database=MyProjectDB;trusted_connection=True;");
        }
        public DbSet<About> Abouts { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Portfolio> Portfolios { get; set; }
        public DbSet<Experience> Experiences { get; set; }
        public DbSet<ExperienceTwo> ExperienceTwos { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<SocialMedia> SocialMedias { get; set; }
        public DbSet<SkillTwo> SkillTwos { get; set; }
    }
}
