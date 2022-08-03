using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DocsGenius.Models;

namespace DocsGeniusWebAPI.Data
{
    public class DocsGeniusWebAPIContext : DbContext
    {
        public DocsGeniusWebAPIContext (DbContextOptions<DocsGeniusWebAPIContext> options)
            : base(options)
        {
        }

        public DbSet<DocsGenius.Models.DocsTemplate> DocsTemplate { get; set; }
    }
}
