using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OptimoBcTools.Models.DbOptimoBcLive
{
  [Table("BCScanViewLadelisteKopf", Schema = "dbo")]
  public partial class BcScanViewLadelisteKopf
  {
    [Key]
    public string TourCode
    {
      get;
      set;
    }
    public string TourBez
    {
      get;
      set;
    }
    public int TourNr
    {
      get;
      set;
    }
    public int Kalenderwoche
    {
      get;
      set;
    }
    public DateTime AbfahrtAm
    {
      get;
      set;
    }
    public decimal? MengeLiefern
    {
      get;
      set;
    }
    public int? MengeGescant
    {
      get;
      set;
    }
    public decimal? Zeilenvolumen
    {
      get;
      set;
    }
  }
}
