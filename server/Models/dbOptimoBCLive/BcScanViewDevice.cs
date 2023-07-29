using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OptimoBcTools.Models.DbOptimoBcLive
{
  [Table("BCScanViewDevices", Schema = "dbo")]
  public partial class BcScanViewDevice
  {
    [Key]
    public int DeviceID
    {
      get;
      set;
    }
    public string DeviceBezeichnung
    {
      get;
      set;
    }
    public string DeviceNummer
    {
      get;
      set;
    }
    public string DeviceTitel
    {
      get;
      set;
    }
    public string DeviceTyp
    {
      get;
      set;
    }
    public string Abteilung
    {
      get;
      set;
    }
    public DateTime? RegistriertAm
    {
      get;
      set;
    }
    public DateTime? AnmeldungAm
    {
      get;
      set;
    }
    public DateTime? AbmeldungAm
    {
      get;
      set;
    }
    public string Info
    {
      get;
      set;
    }
  }
}
