using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Notepad.Models;

namespace Notepad.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Note> Notes { get; set; } // Note tablosu

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=mydatabase;Username=postgres;Password=123456;"); 
        }
    }
}

