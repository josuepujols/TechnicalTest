using Microsoft.EntityFrameworkCore;
using Persistence.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Context
{
    class ApplicationDbContext : DbContext
    {
        //DbSet of Books
        public virtual DbSet<Book> Books { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }
        //Another constructor if needed
        public ApplicationDbContext()
        {

        }


    }
}
