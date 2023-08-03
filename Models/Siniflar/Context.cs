using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace g212102053_mehmet_kaan_akcan_odev.Models.Siniflar
{
    public class Context: DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Player> Players { get; set; }
        public DbSet<Main> Mains { get; set; }
        public DbSet<History> Historys { get; set; }
        public DbSet<MainImage> MainImages { get; set; }
        public DbSet<Contact> Contacts { get; set; }
    }
}