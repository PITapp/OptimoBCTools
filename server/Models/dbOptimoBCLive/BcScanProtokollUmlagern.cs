using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OptimoBcTools.Models.DbOptimoBcLive
{
  [Table("BCScanProtokollUmlagern", Schema = "dbo")]
  public partial class BcScanProtokollUmlagern
  {
    [Timestamp]
    public Byte[] timestamp
    {
      get;
      set;
    }
    public int? Menge
    {
      get;
      set;
    }
    public string ArtikelBez
    {
      get;
      set;
    }
    public string Einheit
    {
      get;
      set;
    }
    public string ArtikelNr
    {
      get;
      set;
    }
    public int? BenutzerID
    {
      get;
      set;
    }
    public int? DeviceID
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
    public string UmlagernArt
    {
      get;
      set;
    }
  }
}
