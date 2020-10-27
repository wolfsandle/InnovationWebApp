using System.Reflection;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.Extensions.Configuration;

using InnovationWebApp.Models.InnovateDb;

namespace InnovationWebApp.Data
{
  public partial class InnovateDbContext : Microsoft.EntityFrameworkCore.DbContext
  {
    public InnovateDbContext(DbContextOptions<InnovateDbContext> options):base(options)
    {
    }

    public InnovateDbContext()
    {
    }

    partial void OnModelBuilding(ModelBuilder builder);

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);


        builder.Entity<InnovationWebApp.Models.InnovateDb.Idea>()
              .Property(p => p.date)
              .HasDefaultValueSql("CURRENT_TIMESTAMP");

        builder.Entity<InnovationWebApp.Models.InnovateDb.Idea>()
              .Property(p => p.votes)
              .HasDefaultValueSql("0");


        this.OnModelBuilding(builder);
    }


    public DbSet<InnovationWebApp.Models.InnovateDb.Idea> Ideas
    {
      get;
      set;
    }

    public DbSet<InnovationWebApp.Models.InnovateDb.Vote> Votes
    {
      get;
      set;
    }
  }
}
