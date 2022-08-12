using DocsGenius.Models;
using DocsGeniusWebAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace DocsGeniusWebAPI.Data
{
    public class ApiDbContext : DbContext
    {
        public ApiDbContext(DbContextOptions<ApiDbContext> options) : base(options)
        {

        }

        public DbSet<DocsResult> DocsResults { get; set; }

        public DbSet<DocType> DocTypes { get; set; }

        public DbSet<Field> Fields { get; set; }

        public DbSet<FieldAux> FieldAuxes { get; set; }

        public DbSet<DocTemplate> DocTemplates { get; set; }

        public DbSet<CreatedDoc> CreatedDocs { get; set; }










    }
}
