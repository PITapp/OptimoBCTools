using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OptimoBcTools.Models.DbOptimoBcLive
{
  [Table("BCScanViewProtokollUmlagern", Schema = "dbo")]
  public partial class BcScanViewProtokollUmlagern
  {
    [Key]
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
    public int? BenutzerID
    {
      get;
      set;
    }
    public DateTime? ProtokollAm
    {
      get;
      set;
    }
    public string UmlagernArt
    {
      get;
      set;
    }
    public string ArtikelNr
    {
      get;
      set;
    }
    public string ArtikelBez
    {
      get;
      set;
    }
    public int? Menge
    {
      get;
      set;
    }
    public string Einheit
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
    public string DeviceBezeichnung
    {
      get;
      set;
    }
    public string Benutzername
    {
      get;
      set;
    }
    public string UmlagernArtTitel
    {
      get;
      set;
    }
  }
}
