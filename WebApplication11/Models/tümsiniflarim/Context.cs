using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApplication11.Models.tümsiniflarim
{
    public class Context:DbContext
    {
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Marka> Markas { get; set; }
        public DbSet<Urun> Uruns { get; set; }
    }
}