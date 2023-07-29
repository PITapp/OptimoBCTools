using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OptimoBcTools.Models.DbOptimoBcLive
{
  [Table("BCScanDevices", Schema = "dbo")]
  public partial class BcScanDevice
  {
    public string DeviceNummer
    {
      get;
      set;
    }
    public DateTime? RegistriertAm
    {
      get;
      set;
    }
    public string DeviceTitel
    {
      get;
      set;
    }
    public string Info
    {
      get;
      set;
    }
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
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
    public string Abteilung
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
    public string DeviceTyp
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
  }
}
