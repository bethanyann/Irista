using Irista.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Text;

namespace Irista.Data.Context
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Photo> Photos { get; set; }
        public DbSet<Album> Albums { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Location> Location { get; set; }
        public DbSet<Metadata> Metadata { get; set; }

        public string test { get; set; }

        public ApplicationDbContext(DbContextOptions options) : base(options)
        { }

        //called at the time DbContext is being initilized
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);



            //might go back to using this in the future so leaving it here for now
            // new AlbumConfiguration().Configure(modelBuilder.Entity<Album>());
            //modelBuilder.Entity<Photo>()
            //    .HasMany(p => p.Tags)
            //    .WithMany(t => t.Photos);
        }

        public class ContextFactory : IDesignTimeDbContextFactory<ApplicationDbContext>
        {
            public ApplicationDbContext CreateDbContext(string[] args)
            {
                var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();
                optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=IristaLocal;Trusted_Connection=True;MultipleActiveResultSets=true",
                    options => options.CommandTimeout((int)TimeSpan.FromMinutes(5).TotalSeconds));

                return new ApplicationDbContext(optionsBuilder.Options);
            }

        }
    }

}
