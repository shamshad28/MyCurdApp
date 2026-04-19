using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MyCurdApp.Models;

namespace MyCurdApp.Data
{
    public class MyCurdAppContext : DbContext
    {
        public MyCurdAppContext (DbContextOptions<MyCurdAppContext> options)
            : base(options)
        {
        }

        public DbSet<MyCurdApp.Models.Student> Student { get; set; } = default!;
    }
}
