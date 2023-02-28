using EntityLayer.Concrate;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrate
{
    public class Context : DbContext /*Veri tabanina yansiyacak tablolari ve baglanti stringini tutar*/
    {
        //tablolari cagiracagiz dbset turunde

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //baglanti stringi tutmak icin kullandik

            optionsBuilder.UseSqlServer("server=DESKTOP-RU7O3J5;database=CorePrejemDb;" +
                "integrated security = true");
        }

        public  DbSet<About>  Abouts { get; set; }
        public  DbSet<Contact> Contacts { get; set; }
        public  DbSet<Experince> Experinces { get; set; }
        public  DbSet<Feature> Features { get; set; }
        public  DbSet<Message> Messages { get; set; }
        public  DbSet<Portfolio>Portfolios  { get; set; }
        public  DbSet<Service> Services  { get; set; }
        public  DbSet<Skill> Skills  { get; set; }
        public  DbSet<SocialMedia> SocialMedias  { get; set; }
        public  DbSet<Testimonial> Testimonials   { get; set; }
    }
}
