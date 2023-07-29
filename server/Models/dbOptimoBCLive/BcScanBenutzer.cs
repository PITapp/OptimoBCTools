using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OptimoBcTools.Models.DbOptimoBcLive
{
  [Table("BCScanBenutzer", Schema = "dbo")]
  public partial class BcScanBenutzer
  {
    public string Strasse
    {
      get;
      set;
    }
    public string Versicherungsnummer
    {
      get;
      set;
    }
    public string EMail2
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
    public string Benutzername
    {
      get;
      set;
    }
    public string Name1
    {
      get;
      set;
    }
    public string TitelHinten
    {
      get;
      set;
    }
    public string Telefon2
    {
      get;
      set;
    }
    public string BildURL
    {
      get;
      set;
    }
    public string Abteilung
    {
      get;
      set;
    }
    public DateTime? Geburtsdatum
    {
      get;
      set;
    }
    public string Initialen
    {
      get;
      set;
    }
    public int? AnredeID
    {
      get;
      set;
    }
    public string PLZ
    {
      get;
      set;
    }
    public string Notiz
    {
      get;
      set;
    }
    public string NameKuerzel
    {
      get;
      set;
    }
    public string EMail1
    {
      get;
      set;
    }
    public string Name2
    {
      get;
      set;
    }
    public string TitelVorne
    {
      get;
      set;
    }
    public string Telefon1
    {
      get;
      set;
    }
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int BenutzerID
    {
      get;
      set;
    }
    public string Ort
    {
      get;
      set;
    }
    public string Staatsangehoerigkeit
    {
      get;
      set;
    }
    public string Webseite
    {
      get;
      set;
    }
  }
}
