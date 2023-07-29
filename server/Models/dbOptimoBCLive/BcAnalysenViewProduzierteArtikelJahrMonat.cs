using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OptimoBcTools.Models.DbOptimoBcLive
{
  [Table("BCAnalysenViewProduzierteArtikelJahrMonat", Schema = "dbo")]
  public partial class BcAnalysenViewProduzierteArtikelJahrMonat
  {
    public int? Year
    {
      get;
      set;
    }
    [Key]
    public string ItemType
    {
      get;
      set;
    }

    [Column("Jänner")]
    public int? Jnner
    {
      get;
      set;
    }
    public int? Februar
    {
      get;
      set;
    }

    [Column("März")]
    public int? Mrz
    {
      get;
      set;
    }
    public int? April
    {
      get;
      set;
    }
    public int? Mai
    {
      get;
      set;
    }
    public int? Juni
    {
      get;
      set;
    }
    public int? Juli
    {
      get;
      set;
    }
    public int? August
    {
      get;
      set;
    }
    public int? September
    {
      get;
      set;
    }
    public int? Oktober
    {
      get;
      set;
    }
    public int? November
    {
      get;
      set;
    }
    public int? Dezember
    {
      get;
      set;
    }
    public int? Jahrssumme
    {
      get;
      set;
    }
  }
}
