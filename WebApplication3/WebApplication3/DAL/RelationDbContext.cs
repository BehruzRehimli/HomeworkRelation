using Microsoft.EntityFrameworkCore;
using WebApplication3.Models;

namespace WebApplication3.DAL
{
    public class RelationDbContext:DbContext
    {

        public RelationDbContext(DbContextOptions<RelationDbContext> opt):base(opt)
        {

        }

        public DbSet<Chef> Chefs { get; set; }
        public DbSet<ChefSocialMedia> SocialMedias { get; set; }
        public DbSet<Testemonial> Testimonials { get; set;}
        public DbSet<ChefProfession> ChefProfessions { get; set; }
        public DbSet<TestemonialProfession> TestemonialProfessions { get; set; }

    }
}
