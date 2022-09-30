using DataAccess.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Context
{
    public class AppDBContext : DbContext
    {
        public DbSet<About> Abouts { get; set; }
        public DbSet<Color> Colors { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Currency> Currencies { get; set; }
        public DbSet<MarkaClassic> MarkaClassics { get; set; }
        public DbSet<MarkaDiscount> MarkaDiscounts { get; set; }
        public DbSet<MarkaSport> MarkaSports { get; set; }
        public DbSet<MarkaStyle> MarkaStyles { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Reklam> Reklams { get; set; }
        public DbSet<ShoeClassic> ShoeClassics { get; set; }
        public DbSet<ShoeDiscount> ShoeDiscounts { get; set; }
        public DbSet<ShoeSport> ShoeSports { get; set; }
        public DbSet<ShoeStyle> ShoeStyles { get; set; }
        public DbSet<Size> Sizes { get; set; }
        public DbSet<SocialMedia> SocialMedias { get; set; }


        public AppDBContext(DbContextOptions<AppDBContext> options)
            : base(options)
        {

        }

    }
}
