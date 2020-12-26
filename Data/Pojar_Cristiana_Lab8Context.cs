using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Pojar_Cristiana_Lab8.Models;

namespace Pojar_Cristiana_Lab8.Data
{
    public class Pojar_Cristiana_Lab8Context : DbContext
    {
        public Pojar_Cristiana_Lab8Context (DbContextOptions<Pojar_Cristiana_Lab8Context> options)
            : base(options)
        {
        }

        public DbSet<Pojar_Cristiana_Lab8.Models.Book> Book { get; set; }
    }
}
