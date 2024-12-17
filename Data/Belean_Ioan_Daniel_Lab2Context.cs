using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Belean_Ioan_Daniel_Lab2.Models;

namespace Belean_Ioan_Daniel_Lab2.Data
{
    public class Belean_Ioan_Daniel_Lab2Context : DbContext
    {
        public Belean_Ioan_Daniel_Lab2Context (DbContextOptions<Belean_Ioan_Daniel_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Belean_Ioan_Daniel_Lab2.Models.Book> Book { get; set; } = default!;
        public DbSet<Belean_Ioan_Daniel_Lab2.Models.Publisher> Publisher { get; set; } = default!;
        public DbSet<Belean_Ioan_Daniel_Lab2.Models.Author> Author { get; set; } = default!;
        public DbSet<Belean_Ioan_Daniel_Lab2.Models.Category> Category { get; set; } = default!;
        public DbSet<Belean_Ioan_Daniel_Lab2.Models.Member> Member { get; set; } = default!;
        public DbSet<Belean_Ioan_Daniel_Lab2.Models.Borrowing> Borrowing { get; set; } = default!;
    }
}
