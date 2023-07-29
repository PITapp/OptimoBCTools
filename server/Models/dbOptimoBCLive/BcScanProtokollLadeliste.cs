using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OptimoBcTools.Models.DbOptimoBcLive
{
  [Table("BCScanProtokollLadeliste", Schema = "dbo")]
  public partial class BcScanProtokollLadeliste
  {
    public DateTime? AbfahrtAm
    {
      get;
      set;
    }
    public string KundeName
    {
      get;
      set;
    }
    public string ArtikelBez
    {
      get;
      set;
    }
    public string TourCode
    {
      get;
      set;
    }
    public int? TourNr
    {
      get;
      set;
    }
    public string VerkaufsauftragNr
    {
      get;
      set;
    }
    public string KundeNr
    {
      get;
      set;
    }
    [Timestamp]
    public Byte[] timestamp
    {
      get;
      set;
    }
    public DateTime? ProtokollAm
    {
      get;
      set;
    }
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int ProtokollID
    {
      get;
      set;
    }
    public int? DeviceID
    {
      get;
      set;
    }
    public string Fertigungsnummer
    {
      get;
      set;
    }
    public int? Kalenderwoche
    {
      get;
      set;
    }
    public string ArtikelNr
    {
      get;
      set;
    }
    public int? Menge
    {
      get;
      set;
    }
    public int? BenutzerID
    {
      get;
      set;
    }
  }
}
