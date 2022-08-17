using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DocsGenius.Models;

namespace DocsGenius.Data
{
    public class DocsGeniusContext : DbContext
    {
        public DocsGeniusContext (DbContextOptions<DocsGeniusContext> options)
            : base(options)
        {
        }

        public DbSet<DocsGenius.Models.DocTemplate> DocTemplate { get; set; }
    }
}
