using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OptimoBcTools.Models.DbOptimoBcLive
{
  [Table("BCScanViewArtikelLagerbestand", Schema = "dbo")]
  public partial class BcScanViewArtikelLagerbestand
  {
    [Key]
    public string ArtikelNr
    {
      get;
      set;
    }
    public decimal? Lagerbestand
    {
      get;
      set;
    }
  }
}
