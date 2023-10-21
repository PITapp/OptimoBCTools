using System.Reflection;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.Extensions.Configuration;

using OptimoBcTools.Models.DbOptimo2003;

namespace OptimoBcTools.Data
{
  public partial class DbOptimo2003Context : Microsoft.EntityFrameworkCore.DbContext
  {
    public DbOptimo2003Context(DbContextOptions<DbOptimo2003Context> options):base(options)
    {
    }

    public DbOptimo2003Context()
    {
    }

    partial void OnModelBuilding(ModelBuilder builder);

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.Entity<OptimoBcTools.Models.DbOptimo2003.BcToolsViewVerkaufsauftraegeOhneFNummer01>().HasNoKey();
        builder.Entity<OptimoBcTools.Models.DbOptimo2003.BcToolsViewVerkaufsauftraegeOhneFNummer02>().HasNoKey();


        builder.Entity<OptimoBcTools.Models.DbOptimo2003.BcToolsViewVerkaufsauftraegeOhneFNummer01>()
              .Property(p => p.Warenausgangsdatum)
              .HasColumnType("datetime");

        builder.Entity<OptimoBcTools.Models.DbOptimo2003.BcToolsViewVerkaufsauftraegeOhneFNummer01>()
              .Property(p => p.Fertigstellungsdatum)
              .HasColumnType("datetime");

        builder.Entity<OptimoBcTools.Models.DbOptimo2003.BcToolsViewVerkaufsauftraegeOhneFNummer01>()
              .Property(p => p.GewnschtesLieferdatum)
              .HasColumnType("datetime");

        builder.Entity<OptimoBcTools.Models.DbOptimo2003.BcToolsViewVerkaufsauftraegeOhneFNummer01>()
              .Property(p => p.GeplantesLieferdatum)
              .HasColumnType("datetime");

        builder.Entity<OptimoBcTools.Models.DbOptimo2003.BcToolsViewVerkaufsauftraegeOhneFNummer01>()
              .Property(p => p.GeplantesWarenausgangsdatum)
              .HasColumnType("datetime");

        builder.Entity<OptimoBcTools.Models.DbOptimo2003.BcToolsViewVerkaufsauftraegeOhneFNummer02>()
              .Property(p => p.Warenausgangsdatum)
              .HasColumnType("datetime");

        builder.Entity<OptimoBcTools.Models.DbOptimo2003.BcToolsViewVerkaufsauftraegeOhneFNummer02>()
              .Property(p => p.GeplantesLieferdatum)
              .HasColumnType("datetime");

        builder.Entity<OptimoBcTools.Models.DbOptimo2003.BcToolsViewVerkaufsauftraegeOhneFNummer01>()
              .Property(p => p.MengeGeliefert)
              .HasPrecision(38, 20);
        this.OnModelBuilding(builder);
    }


    public DbSet<OptimoBcTools.Models.DbOptimo2003.BcToolsViewVerkaufsauftraegeOhneFNummer01> BcToolsViewVerkaufsauftraegeOhneFNummer01s
    {
      get;
      set;
    }

    public DbSet<OptimoBcTools.Models.DbOptimo2003.BcToolsViewVerkaufsauftraegeOhneFNummer02> BcToolsViewVerkaufsauftraegeOhneFNummer02s
    {
      get;
      set;
    }

    protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
    {
        configurationBuilder.Conventions.Add(_ => new BlankTriggerAddingConvention());
    }
  }
}
