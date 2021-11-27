using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Neag_Andreea_Lab8.Models;

namespace Neag_Andreea_Lab8.Data
{
    public class Neag_Andreea_Lab8Context : DbContext
    {
        public Neag_Andreea_Lab8Context (DbContextOptions<Neag_Andreea_Lab8Context> options)
            : base(options)
        {
        }

        public DbSet<Neag_Andreea_Lab8.Models.Book> Books { get; set; }

        public DbSet<Neag_Andreea_Lab8.Models.Publisher> Publisher { get; set; }

        public DbSet<Neag_Andreea_Lab8.Models.BookCategory> BookCategory { get; set; }
    }
}
